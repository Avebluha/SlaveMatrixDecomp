using _2DGAMELIB;
using System;
using System.Collections.Generic;

namespace SlaveEngine.Graphics {
    public static class Spline {
        
        /// <summary>
        /// Converts a Cardinal Spline (GDI+ style) to a polyline.
        /// </summary>
        public static List<Vector2D> CardinalSplineToPolyline(double tension, List<Vector2D> points, bool closed, double delta = 0.02)
        {
            var polyline = new List<Vector2D>();
            if (points == null || points.Count < 2) return polyline;

            int n = points.Count;
            int segments = closed ? n : n - 1;

            for (int i = 0; i < segments; i++)
            {
                int p0Idx = (i - 1 + n) % n;
                int p1Idx = i;
                int p2Idx = (i + 1) % n;
                int p3Idx = (i + 2) % n;

                if (!closed)
                {
                    p0Idx = System.Math.Max(i - 1, 0);
                    p1Idx = i;
                    p2Idx = i + 1;
                    p3Idx = System.Math.Min(i + 2, n - 1);
                }

                var p0 = points[p0Idx];
                var p1 = points[p1Idx];
                var p2 = points[p2Idx];
                var p3 = points[p3Idx];

                // Cardinal Spline to Hermite tangents
                // m1 = (1-t) * (p2 - p0) / 2
                // m2 = (1-t) * (p3 - p1) / 2
                var m1 = (p2 - p0) * (1.0 - tension) * 0.5;
                var m2 = (p3 - p1) * (1.0 - tension) * 0.5;

                // Evaluate Hermite spline segment
                for (double t = 0.0; t < 1.0; t += delta)
                {
                    polyline.Add(EvaluateHermite(p1, m1, p2, m2, t));
                }
            }

            if (!closed)
            {
                polyline.Add(points.Last());
            }

            return polyline;
        }

        private static Vector2D EvaluateHermite(Vector2D p1, Vector2D m1, Vector2D p2, Vector2D m2, double t)
        {
            double t2 = t * t;
            double t3 = t2 * t;

            // Hermite basis functions
            double h1 = 2 * t3 - 3 * t2 + 1;
            double h2 = -2 * t3 + 3 * t2;
            double h3 = t3 - 2 * t2 + t;
            double h4 = t3 - t2;

            return p1 * h1 + p2 * h2 + m1 * h3 + m2 * h4;
        }

        // Keep existing Beziers for SVG compatibility
        public static List<Vector2D> CubicBezierToPolyline(Vector2D p0, Vector2D p1, Vector2D p2, Vector2D p3, double delta = 0.02)
        {
            var polyline = new List<Vector2D>();
            for (double t = 0; t < 1.0; t += delta)
            {
                polyline.Add(EvaluateCubicBezier(p0, p1, p2, p3, t));
            }
            polyline.Add(p3);
            return polyline;
        }

        private static Vector2D EvaluateCubicBezier(Vector2D p0, Vector2D p1, Vector2D p2, Vector2D p3, double t)
        {
            double u = 1.0 - t;
            double tt = t * t;
            double uu = u * u;
            return p0 * (uu * u) + p1 * (3 * uu * t) + p2 * (3 * u * tt) + p3 * (tt * t);
        }
    }
}
