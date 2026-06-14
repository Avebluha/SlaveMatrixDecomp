
using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveEngine.Graphics {
    public static class Triangulation {
    public static List<double> Triangulate(List<Vector2D> polyline)
    {
        var result = new List<double>();
        if (polyline == null || polyline.Count < 3) return result;

        // defensive copy and ensure path loop is closed without duplicate terminals
        var vertices = new List<Vector2D>(polyline);
        if ((vertices[0] - vertices[vertices.Count - 1]).LengthSquared() < 1e-9)
        {
            vertices.RemoveAt(vertices.Count - 1);
        }

        if (vertices.Count < 3) return result;

        // tracking working indices for ear-clipping loop pass
        var indices = new List<int>();
        for (int i = 0; i < vertices.Count; i++) indices.Add(i);

        // ensure polygon orientation winding order is counter-clockwise
        double area = 0;
        for (int i = 0; i < vertices.Count; i++)
        {
            var p1 = vertices[i];
            var p2 = vertices[(i + 1) % vertices.Count];
            area += (p2.X - p1.X) * (p2.Y + p1.Y);
        }
        if (area > 0) indices.Reverse(); // flip orientation order if clockwise

        // ear clipping triangulation loop
        while (indices.Count >= 3)
        {
            bool earFound = false;

            for (int i = 0; i < indices.Count; i++)
            {
                int prevIdx = indices[(i - 1 + indices.Count) % indices.Count];
                int currIdx = indices[i];
                int nextIdx = indices[(i + 1) % indices.Count];

                var a = vertices[prevIdx];
                var b = vertices[currIdx];
                var c = vertices[nextIdx];

                // check if the triangle forms a valid reflex/convex corner edge layout
                double crossProduct = (b.X - a.X) * (c.Y - b.Y) - (b.Y - a.Y) * (c.X - b.X);
                if (crossProduct <= 0) continue; // skip reflex angles

                // verify no other remaining polygon nodes reside inside the tested triangle boundary bounds
                bool containsPoint = false;
                for (int j = 0; j < indices.Count; j++)
                {
                    int testIdx = indices[j];
                    if (testIdx == prevIdx || testIdx == currIdx || testIdx == nextIdx) continue;

                    if (IsPointInTriangle(vertices[testIdx], a, b, c))
                    {
                        containsPoint = true;
                        break;
                    }
                }

                if (!containsPoint)
                {
                    // write out the valid primitive tuple sequence: X, Y, 0, 0
                    AddVertexTuple(result, a);
                    AddVertexTuple(result, b);
                    AddVertexTuple(result, c);

                    indices.RemoveAt(i);
                    earFound = true;
                    break;
                }
            }

            // fallback break condition to prevent infinite loops on broken/self-intersecting paths
            if (!earFound) break; 
        }

        return result;
    }


public static List<double> ToStrip(double thickness, List<Vector2D> path, bool closed)
{
    var result = new List<double>();
    if (path == null || path.Count < 2) return result;

    double halfThickness = thickness / 2.0;
    int count = path.Count;
    
    var leftVertices = new Vector2D[count];
    var rightVertices = new Vector2D[count];

    Vector2D LocalNormalize(Vector2D v)
    {
        double len = System.Math.Sqrt(v.X * v.X + v.Y * v.Y);
        if (len < 1e-9) return new Vector2D(0, 0);
        return new Vector2D(v.X / len, v.Y / len);
    }

    // 1. compute smooth miter offsets along the line layout
    for (int i = 0; i < count; i++)
    {
        if (!closed && i == 0)
        {
            var tangent = LocalNormalize(path[1] - path[0]);
            var normal = new Vector2D(-tangent.Y, tangent.X);
            leftVertices[i] = path[0] + normal * halfThickness;
            rightVertices[i] = path[0] - normal * halfThickness;
        }
        else if (!closed && i == count - 1)
        {
            var tangent = LocalNormalize(path[count - 1] - path[count - 2]);
            var normal = new Vector2D(-tangent.Y, tangent.X);
            leftVertices[i] = path[count - 1] + normal * halfThickness;
            rightVertices[i] = path[count - 1] - normal * halfThickness;
        }
        else
        {
            // wrap boundary elements symmetrically if the path is closed
            var prevNode = path[(i - 1 + count) % count];
            var currNode = path[i];
            var nextNode = path[(i + 1) % count];

            var t1 = LocalNormalize(currNode - prevNode);
            var t2 = LocalNormalize(nextNode - currNode);
            var tangent = LocalNormalize(t1 + t2);
            var miter = new Vector2D(-tangent.Y, tangent.X);
            var n1 = new Vector2D(-t1.Y, t1.X);

            double dot = miter.X * n1.X + miter.Y * n1.Y;
            double miterLength = halfThickness;

            if (System.Math.Abs(dot) > 1e-6)
            {
                miterLength = halfThickness / dot;
            }

            double miterLimit = thickness * 2.5;
            if (System.Math.Abs(miterLength) > miterLimit)
            {
                miterLength = miterLimit * System.Math.Sign(miterLength);
            }

            leftVertices[i] = currNode + miter * miterLength;
            rightVertices[i] = currNode - miter * miterLength;
        }
    }

    // 2. generate round start cap only if the loop path is open
    if (!closed)
    {
        int capSegments = 8; 
        var startTangent = LocalNormalize(path[1] - path[0]);

        for (int i = 0; i < capSegments; i++)
        {
            double angle1 = System.Math.PI / 2.0 + (i * System.Math.PI / capSegments);
            double angle2 = System.Math.PI / 2.0 + ((i + 1) * System.Math.PI / capSegments);

            var r1 = new Vector2D(startTangent.X * System.Math.Cos(angle1) - startTangent.Y * System.Math.Sin(angle1), startTangent.X * System.Math.Sin(angle1) + startTangent.Y * System.Math.Cos(angle1));
            var r2 = new Vector2D(startTangent.X * System.Math.Cos(angle2) - startTangent.Y * System.Math.Sin(angle2), startTangent.X * System.Math.Sin(angle2) + startTangent.Y * System.Math.Cos(angle2));

            AddVertexTuple(result, path[0]);
            AddVertexTuple(result, path[0] + r1 * halfThickness);
            AddVertexTuple(result, path[0] + r2 * halfThickness);
        }
    }

    // 3. stitch core geometry strip segments
    int segments = closed ? count : count - 1;
    for (int i = 0; i < segments; i++)
    {
        var v1 = leftVertices[i];
        var v2 = rightVertices[i];
        var v3 = leftVertices[(i + 1) % count];
        var v4 = rightVertices[(i + 1) % count];

        AddVertexTuple(result, v1);
        AddVertexTuple(result, v2);
        AddVertexTuple(result, v3);

        AddVertexTuple(result, v2);
        AddVertexTuple(result, v4);
        AddVertexTuple(result, v3);
    }

    // 4. generate round end cap only if the loop path is open
    if (!closed)
    {
        int capSegments = 8;
        var endTangent = LocalNormalize(path[count - 1] - path[count - 2]);

        for (int i = 0; i < capSegments; i++)
        {
            double angle1 = -System.Math.PI / 2.0 + (i * System.Math.PI / capSegments);
            double angle2 = -System.Math.PI / 2.0 + ((i + 1) * System.Math.PI / capSegments);

            var r1 = new Vector2D(endTangent.X * System.Math.Cos(angle1) - endTangent.Y * System.Math.Sin(angle1), endTangent.X * System.Math.Sin(angle1) + endTangent.Y * System.Math.Cos(angle1));
            var r2 = new Vector2D(endTangent.X * System.Math.Cos(angle2) - endTangent.Y * System.Math.Sin(angle2), endTangent.X * System.Math.Sin(angle2) + endTangent.Y * System.Math.Cos(angle2));

            AddVertexTuple(result, path[count - 1]);
            AddVertexTuple(result, path[count - 1] + r1 * halfThickness);
            AddVertexTuple(result, path[count - 1] + r2 * halfThickness);
        }
    }

    return result;
}
    private static void AddVertexTuple(List<double> list, Vector2D vertex)
    {
        list.Add(vertex.X);
        list.Add(vertex.Y);
        list.Add(0.0);
        list.Add(0.0);
    }

    private static bool IsPointInTriangle(Vector2D p, Vector2D a, Vector2D b, Vector2D c)
    {
        double d1 = Sign(p, a, b);
        double d2 = Sign(p, b, c);
        double d3 = Sign(p, c, a);

        bool hasNeg = (d1 < 0) || (d2 < 0) || (d3 < 0);
        bool hasPos = (d1 > 0) || (d2 > 0) || (d3 > 0);

        return !(hasNeg && hasPos);
    }

    private static double Sign(Vector2D p1, Vector2D p2, Vector2D p3)
    {
        return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
    }
}
}