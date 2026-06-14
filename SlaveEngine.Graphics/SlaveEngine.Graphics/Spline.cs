using _2DGAMELIB;

namespace SlaveEngine.Graphics {
    public static class Spline {
    public static List<Vector2D> CanonicalToBezierSpline(double tension, List<Vector2D> spline, bool closed)
    {
        var bezierPoints = new List<Vector2D>();
        if (spline == null || spline.Count < 2) return bezierPoints;

        double s = (1.0 - tension) / 6.0;
        int count = spline.Count;
        
        // if closed, we loop all the way back to the start point segment boundary
        int segments = closed ? count : count - 1;

        for (int i = 0; i < segments; i++)
        {
            var p1 = spline[i];
            var p2 = spline[(i + 1) % count];

            Vector2D p0, p3;

            if (closed)
            {
                // wrap around indexes symmetrically using modulo mapping
                p0 = spline[(i - 1 + count) % count];
                p3 = spline[(i + 2) % count];
            }
            else
            {
                // fallback to duplicating edge endpoints if open loop boundary
                p0 = (i > 0) ? spline[i - 1] : p1;
                p3 = (i < count - 2) ? spline[i + 2] : p2;
            }

            var tangent1 = new Vector2D(p2.X - p0.X, p2.Y - p0.Y);
            var tangent2 = new Vector2D(p3.X - p1.X, p3.Y - p1.Y);

            var c1 = new Vector2D(p1.X + s * tangent1.X, p1.Y + s * tangent1.Y);
            var c2 = new Vector2D(p2.X - s * tangent2.X, p2.Y - s * tangent2.Y);

            bezierPoints.Add(p1);
            bezierPoints.Add(c1);
            bezierPoints.Add(c2);
            
            // append final terminal point on the very last chunk when open
            if (!closed && i == segments - 1)
            {
                bezierPoints.Add(p2);
            }
        }

        // if closed, seal the final vector chain with the original loop node
        if (closed)
        {
            bezierPoints.Add(spline[0]);
        }

        return bezierPoints;
    }

    public static List<Vector2D> SplineToPolyLine(double delta, List<Vector2D> spline)
    {
        var polyline = new List<Vector2D>();
        if (spline == null || spline.Count < 4) return polyline;

        // step through the list in chunks of 4 points representing distinct cubic bezier segments
        for (int i = 0; i <= spline.Count - 4; i += 3)
        {
            var p0 = spline[i];
            var p1 = spline[i + 1];
            var p2 = spline[i + 2];
            var p3 = spline[i + 3];

            // evaluate the curve points along the resolution step
            for (double t = 0.0; t < 1.0; t += delta)
            {
                polyline.Add(EvaluateCubicBezier(p0, p1, p2, p3, t));
            }
            
            // explicitly sample t=1.0 at the boundary junction to seal gaps
            if (i == spline.Count - 4)
            {
                polyline.Add(p3);
            }
        }

        return polyline;
    }

    private static Vector2D EvaluateCubicBezier(Vector2D p0, Vector2D p1, Vector2D p2, Vector2D p3, double t)
    {
        double u = 1.0 - t;
        double tt = t * t;
        double uu = u * u;
        double uuu = uu * u;
        double ttt = tt * t;

        // Bernstein polynomial mixing weights
        double x = uuu * p0.X + 3.0 * uu * t * p1.X + 3.0 * u * tt * p2.X + ttt * p3.X;
        double y = uuu * p0.Y + 3.0 * uu * t * p1.Y + 3.0 * u * tt * p2.Y + ttt * p3.Y;

        return new Vector2D(x, y);
    }

}
}