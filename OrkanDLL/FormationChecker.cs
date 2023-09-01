using OrkanDLL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL
{
    public static class FormationChecker
    {
        public static bool ProvjeraDronova(int brojDronova)
        {
            if (brojDronova < 3 || brojDronova > 5)
                return false;
            else
                return true;
        }

        public static bool ProvjeriFormaciju(List<Dron> dronovi)
        {
            int brojDronova = dronovi.Count;
            switch (brojDronova)
            {
                case 3:
                    if (!ProvjeriFormacijuTrokuta(dronovi))
                    {
                        return false;
                    }
                    break;
                case 4:
                    if (!ProvjeriFormacijuKvadrata(dronovi))
                    {
                        return false;
                    }
                    break;
                case 5:
                    if (!ProvjeriFormacijuPeterokuta(dronovi))
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }
            return true;
        }

        public static bool ProvjeriFormacijuPeterokuta(List<Dron> dronovi)
        {
            double centerX = dronovi.Average(d => d.Location.X);
            double centerY = dronovi.Average(d => d.Location.Y);

            List<double> udaljenosti = dronovi.Select(d => Math.Sqrt(Math.Pow(d.Location.X - centerX, 2) + Math.Pow(d.Location.Y - centerY, 2))).ToList();

            double prosjecnaUdaljenost = udaljenosti.Average();

            foreach (double udaljenost in udaljenosti)
            {
                if (Math.Abs(udaljenost - prosjecnaUdaljenost) > 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ProvjeriFormacijuKvadrata(List<Dron> dronovi)
        {
            Point[] lokacije = dronovi.Select(x => x.Location).ToArray();

            bool ispravnaFormacija = MathSolver.Dist(lokacije[0], lokacije[1]) == MathSolver.Dist(lokacije[1], lokacije[2]) &&
                MathSolver.Dist(lokacije[1], lokacije[2]) == MathSolver.Dist(lokacije[2], lokacije[3]) &&
                MathSolver.Dist(lokacije[2], lokacije[3]) == MathSolver.Dist(lokacije[3], lokacije[0]) &&
                MathSolver.Dist(lokacije[0], lokacije[2]) == MathSolver.Dist(lokacije[1], lokacije[3]);

            return ispravnaFormacija;
        }

        public static bool ProvjeriFormacijuTrokuta(List<Dron> dronovi)
        {
            Point[] lokacije = dronovi.Select(x => x.Location).ToArray();

            double a = MathSolver.Dist(lokacije[0], lokacije[1]);
            double b = MathSolver.Dist(lokacije[1], lokacije[2]);
            double c = MathSolver.Dist(lokacije[2], lokacije[0]);

            bool ispravnaFormacija = a + b > c && b + c > a && c + a > b;

            bool kutoviVeciOd30Stupnjeva = true;
            for (int i = 0; i < 3; i++)
            {
                Point p1 = lokacije[i];
                Point p2 = lokacije[(i + 1) % 3];
                Point p3 = lokacije[(i + 2) % 3];
                double kut = MathSolver.IzracunajKut(p1, p2, p3);

                if (kut < 30)
                {
                    kutoviVeciOd30Stupnjeva = false;
                    break;
                }
            }

            return ispravnaFormacija && kutoviVeciOd30Stupnjeva;
        }
    }
}
