
using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveEngine.Graphics {
    public static class Triangulation {

    public static List<double> Triangulate(IEnumerable<List<Vector2D>> contours)
    {
        List<double> result = new List<double>();
        List<List<Vector2D>> valid = contours.Select(c => CleanPolyline(c)).Where(c => c.Count >= 3).ToList();
        if (valid.Count == 0) return result;

        int[] parent = new int[valid.Count];
        for (int i = 0; i < valid.Count; i++) parent[i] = -1;

        for (int i = 0; i < valid.Count; i++)
        {
            for (int j = 0; j < valid.Count; j++)
            {
                if (i == j) continue;
                if (IsPointInPolygon(valid[i][0], valid[j]))
                {
                    if (parent[i] == -1 || IsPointInPolygon(valid[j][0], valid[parent[i]]))
                        parent[i] = j;
                }
            }
        }

        List<int>[] children = new List<int>[valid.Count];
        for (int i = 0; i < valid.Count; i++) children[i] = new List<int>();
        for (int i = 0; i < valid.Count; i++) if (parent[i] != -1) children[parent[i]].Add(i);

        for (int i = 0; i < valid.Count; i++)
        {
            int depth = 0;
            int pIdx = parent[i];
            while (pIdx != -1) { pIdx = parent[pIdx]; depth++; }

            if (depth % 2 == 0)
            {
                List<List<Vector2D>> groupHoles = new List<List<Vector2D>>();
                foreach(int childIdx in children[i]) groupHoles.Add(valid[childIdx]);
                result.AddRange(TriangulateWithHoles(valid[i], groupHoles));
            }
        }
        return result;
    }

    private static List<double> TriangulateWithHoles(List<Vector2D> outer, List<List<Vector2D>> holes)
    {
        if (holes.Count == 0) return TriangulateSimple(outer);

        List<Vector2D> mainPoly = new List<Vector2D>(outer);
        if (GetSignedArea(mainPoly) < 0) mainPoly.Reverse();

        foreach (List<Vector2D> h in holes)
        {
            List<Vector2D> hole = new List<Vector2D>(h);
            if (GetSignedArea(hole) > 0) hole.Reverse();

            int mIdx = 0;
            int hIdx = 0;
            double minDist = double.MaxValue;
            for (int m = 0; m < mainPoly.Count; m++)
            {
                for (int hi = 0; hi < hole.Count; hi++)
                {
                    double d = (mainPoly[m] - hole[hi]).LengthSquared();
                    if (d < minDist) { minDist = d; mIdx = m; hIdx = hi; }
                }
            }

            List<Vector2D> bridge = new List<Vector2D>();
            for (int j = 0; j <= hole.Count; j++) bridge.Add(hole[(hIdx + j) % hole.Count]);
            bridge.Add(mainPoly[mIdx]);
            mainPoly.InsertRange(mIdx + 1, bridge);
        }
        return TriangulateSimple(mainPoly);
    }

    public static List<double> Triangulate(List<Vector2D> polyline) => TriangulateSimple(CleanPolyline(polyline));

    private static List<double> TriangulateSimple(List<Vector2D> vertices)
    {
        List<double> result = new List<double>();
        if (vertices.Count < 3) return result;
        List<int> indices = new List<int>();
        for (int i = 0; i < vertices.Count; i++) indices.Add(i);
        
        double area = 0;
        for (int i = 0; i < vertices.Count; i++)
            area += (vertices[(i + 1) % vertices.Count].X - vertices[i].X) * (vertices[(i + 1) % vertices.Count].Y + vertices[i].Y);
        if (area < 0) indices.Reverse();

        int safety = indices.Count * 10;
        while (indices.Count >= 3 && safety-- > 0)
        {
            bool earFound = false;
            for (int i = 0; i < indices.Count; i++)
            {
                int p = indices[(i - 1 + indices.Count) % indices.Count];
                int c = indices[i];
                int n = indices[(i + 1) % indices.Count];
                Vector2D va = vertices[p]; 
                Vector2D vb = vertices[c]; 
                Vector2D vc = vertices[n];
                if ((vb.X - va.X) * (vc.Y - va.Y) - (vb.Y - va.Y) * (vc.X - va.X) >= -1e-12) continue;
                bool inside = false;
                for (int j = 0; j < indices.Count; j++)
                {
                    int tIdx = indices[j];
                    if (tIdx == p || tIdx == c || tIdx == n) continue;
                    if (IsPointInTriangle(vertices[tIdx], va, vb, vc)) { inside = true; break; }
                }
                if (!inside) { AddVertexTuple(result, va); AddVertexTuple(result, vb); AddVertexTuple(result, vc); indices.RemoveAt(i); earFound = true; break; }
            }
            if (!earFound) break;
        }
        return result;
    }

    public static List<double> ToStrip(double thickness, List<Vector2D> path, bool closed, double delta = 0.02)
    {
        List<double> result = new List<double>();
        if (path == null || path.Count < 2) return result;
        double r = thickness / 2.0;
        int count = path.Count;

        for (int i = 0; i < (closed ? count : count - 1); i++)
        {
            Vector2D p0 = path[i]; 
            Vector2D p1 = path[(i + 1) % count];
            Vector2D tan = GetStableTangent(path, i, count, closed, true);
            if (tan.LengthSquared() < 0.5) continue;
            Vector2D norm = new Vector2D(-tan.Y, tan.X);
            AddTriangle(result, p0 + norm * r, p0 - norm * r, p1 + norm * r);
            AddTriangle(result, p0 - norm * r, p1 - norm * r, p1 + norm * r);
        }

        for (int i = 0; i < (closed ? count : count - 2); i++)
        {
            Vector2D pc = path[(i + 1) % count];
            Vector2D t1 = GetStableTangent(path, i, count, closed, true);
            Vector2D t2 = GetStableTangent(path, (i + 1) % count, count, closed, true);
            if (t1.LengthSquared() < 0.5 || t2.LengthSquared() < 0.5) continue;
            GenerateArc(result, pc, new Vector2D(-t1.Y, t1.X), new Vector2D(-t2.Y, t2.X), r, delta, false, 0);
            GenerateArc(result, pc, new Vector2D(t1.Y, -t1.X), new Vector2D(t2.Y, -t2.X), r, delta, false, 0);
        }

        if (!closed)
        {
            GenerateCircle(result, path[0], r, delta);
            GenerateCircle(result, path[count - 1], r, delta);
        }
        return result;
    }

    private static void GenerateCircle(List<double> result, Vector2D center, double r, double delta)
    {
        int steps = (int)System.Math.Max(16.0, System.Math.Ceiling(2.0 * System.Math.PI * r / delta));
        for (int i = 0; i < steps; i++)
        {
            double ang1 = (double)i / steps * 2.0 * System.Math.PI;
            double ang2 = (double)(i + 1) / steps * 2.0 * System.Math.PI;
            AddTriangle(result, center, center + new Vector2D(System.Math.Cos(ang1) * r, System.Math.Sin(ang1) * r), center + new Vector2D(System.Math.Cos(ang2) * r, System.Math.Sin(ang2) * r));
        }
    }

    private static void GenerateArc(List<double> result, Vector2D center, Vector2D vStart, Vector2D vEnd, double r, double delta, bool isCap, double forcedSweepSign)
    {
        double a1 = System.Math.Atan2(vStart.Y, vStart.X);
        double a2 = System.Math.Atan2(vEnd.Y, vEnd.X);
        double diff = a2 - a1;
        while (diff < -System.Math.PI) diff += 2 * System.Math.PI;
        while (diff > System.Math.PI) diff -= 2 * System.Math.PI;
        if (System.Math.Abs(diff) < 1e-6) return;

        int steps = (int)System.Math.Max(isCap ? 16.0 : 2.0, System.Math.Ceiling(System.Math.Abs(diff) * r / delta));
        for (int i = 0; i < steps; i++)
        {
            double ang1 = a1 + (double)i / steps * diff;
            double ang2 = a1 + (double)(i + 1) / steps * diff;
            AddTriangle(result, center, center + new Vector2D(System.Math.Cos(ang1) * r, System.Math.Sin(ang1) * r), center + new Vector2D(System.Math.Cos(ang2) * r, System.Math.Sin(ang2) * r));
        }
    }

    private static Vector2D GetStableTangent(List<Vector2D> path, int i, int count, bool closed, bool forward)
    {
        int step = forward ? 1 : -1;
        Vector2D p1 = path[i];
        for (int s = 1; s < 10; s++) {
            int nextIdx = (i + s * step + count) % count;
            if (!closed && (nextIdx < 0 || nextIdx >= count)) break;
            Vector2D t = LocalNormalize(path[nextIdx] - p1);
            if (t.LengthSquared() > 0.5) return forward ? t : LocalNormalize(p1 - path[nextIdx]);
        }
        return forward ? LocalNormalize(path[(i+1)%count] - p1) : LocalNormalize(p1 - path[(i-1+count)%count]);
    }

    private static void AddTriangle(List<double> res, Vector2D a, Vector2D b, Vector2D c)
    {
        double cp = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - b.X);
        if (cp > 0) { AddVertexTuple(res, a); AddVertexTuple(res, c); AddVertexTuple(res, b); }
        else { AddVertexTuple(res, a); AddVertexTuple(res, b); AddVertexTuple(res, c); }
    }

    private static List<Vector2D> CleanPolyline(List<Vector2D> polyline)
    {
        List<Vector2D> cleaned = new List<Vector2D>();
        foreach (Vector2D p in polyline) if (cleaned.Count == 0 || (p - cleaned.Last()).LengthSquared() > 1e-12) cleaned.Add(p);
        if (cleaned.Count > 1 && (cleaned[0] - cleaned.Last()).LengthSquared() < 1e-12) cleaned.RemoveAt(cleaned.Count - 1);
        if (cleaned.Count < 3) return cleaned;
        List<Vector2D> noCollinear = new List<Vector2D>();
        for (int i = 0; i < cleaned.Count; i++)
        {
            Vector2D p1 = cleaned[(i - 1 + cleaned.Count) % cleaned.Count];
            Vector2D p2 = cleaned[i];
            Vector2D p3 = cleaned[(i + 1) % cleaned.Count];
            if (System.Math.Abs((p2.X - p1.X) * (p3.Y - p2.Y) - (p2.Y - p1.Y) * (p3.X - p2.X)) > 1e-12) noCollinear.Add(p2);
        }
        return noCollinear;
    }

    private static bool IsPointInPolygon(Vector2D p, List<Vector2D> poly)
    {
        bool inside = false;
        for (int i = 0, j = poly.Count - 1; i < poly.Count; j = i++)
            if (((poly[i].Y > p.Y) != (poly[j].Y > p.Y)) && (p.X < (poly[j].X - poly[i].X) * (p.Y - poly[i].Y) / (poly[j].Y - poly[i].Y) + poly[i].X)) inside = !inside;
        return inside;
    }

    private static double GetSignedArea(List<Vector2D> p)
    {
        double a = 0;
        for (int i = 0; i < p.Count; i++) a += (p[(i + 1) % p.Count].X - p[i].X) * (p[(i + 1) % p.Count].Y + p[i].Y);
        return a;
    }

    private static Vector2D LocalNormalize(Vector2D v) { double l = System.Math.Sqrt(v.X * v.X + v.Y * v.Y); return l < 1e-12 ? new Vector2D(0, 0) : new Vector2D(v.X / l, v.Y / l); }
    private static void AddVertexTuple(List<double> list, Vector2D v) { list.Add(v.X); list.Add(v.Y); list.Add(0.0); list.Add(0.0); }
    private static bool IsPointInTriangle(Vector2D p, Vector2D a, Vector2D b, Vector2D c)
    {
        double d1 = Sign(p, a, b);
        double d2 = Sign(p, b, c);
        double d3 = Sign(p, c, a);
        return !((d1 < -1e-12 || d2 < -1e-12 || d3 < -1e-12) && (d1 > 1e-12 || d2 > 1e-12 || d3 > 1e-12));
    }
    private static double Sign(Vector2D p1, Vector2D p2, Vector2D p3) => (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
}
}
