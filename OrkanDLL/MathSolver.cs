using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL
{
    public static class MathSolver
    {
        public static double IzracunajKut(Point p1, Point p2, Point p3)
        {
            double a = Dist(p2, p3);
            double b = Dist(p1, p3);
            double c = Dist(p1, p2);

            double kutRad = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            double kutStupnjevi = kutRad * (180 / Math.PI);

            return kutStupnjevi;
        }

        public static double Dist(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
