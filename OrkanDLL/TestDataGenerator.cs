using OrkanDLL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL
{
    public static class TestDataGenerator
    {
        public static void GenerirajPodatkeBaterije(List<Dron> dronovi)
        {
            Random random = new Random();
            foreach (var dron in dronovi)
            {
                dron.BatteryStatus = random.Next(1, 100);
            }
        }

        public static List<Point> KreirajPocetnePozicijeDronovaZaFormacije(int brojDronova)
        {
            switch (brojDronova)
            {
                case 3:
                    return new List<Point>
                    {
                        new Point (0,0),
                        new Point (50,0),
                        new Point (25,50)
                    };
                    break;
                case 4:
                    return new List<Point>
                    {
                        new Point (50,0),
                        new Point (100, 0),
                        new Point (100, 100),
                        new Point (50, 100)
                    };
                    break;
                case 5:
                    List<Point> lista = KreirajKoordinatePeterokuta(30);
                    return lista;
                    break;
                default:
                    return null;
            }
        }

        public static List<Point> KreirajKoordinatePeterokuta(int radius)
        {
            int brojDronova = 5;
            Point centar = new Point(450, 300);
            List<Point> koordinate = new List<Point>();

            for (int i = 0; i < brojDronova; i++)
            {
                double kut = 2 * Math.PI * i / brojDronova;
                int x = centar.X + (int)(radius * Math.Cos(kut));
                int y = centar.Y + (int)(radius * Math.Sin(kut));
                koordinate.Add(new Point(x, y));
            }

            return koordinate;
        }

        public static void KreirajNasumicnePozicijeDronovaZaFormacije(int brojDronova, List<Dron> dronovi)
        {
            Random random = new Random();
            switch (brojDronova)
            {
                case 3:
                    {
                        List<Point> pozicije = new List<Point>
                    {
                        new Point(random.Next(300, 450), random.Next(300, 400)),
                        new Point(random.Next(300, 450), random.Next(300, 400)),
                        new Point(random.Next(300, 450), random.Next(300, 400)),
                    };

                        for (int i = 0; i < 3; i++)
                        {
                            dronovi[i].Location = pozicije[i];
                        }
                        break;
                    }
                case 4:
                    {
                        List<Point> pozicije = new List<Point>
                        {
                            new Point (400,300),
                            new Point (450, 300),
                            new Point (450, 350),
                            new Point (400, 350)
                        };

                        for (int i = 0; i < brojDronova; i++)
                        {
                            dronovi[i].Location = pozicije[i];
                        }
                        break;
                    }

                case 5:
                    {
                        List<Point> koordinate = TestDataGenerator.KreirajKoordinatePeterokuta(random.Next(0, 100));
                        for (int i = 0; i < 5; i++)
                        {
                            dronovi[i].Location = koordinate[i];
                        }
                        break;
                    }
            }
        }

        public static void PomicanjeDrona(List<Dron> dronovi)
        {
            Random random = new Random();
            foreach (var dron in dronovi)
            {
                int x = random.Next(0, 3);
                int y = random.Next(0, 3);
                Point oldLocation = dron.Location;
                Point newLocation = new Point(oldLocation.X + x, oldLocation.Y + y);
                dron.Location = newLocation;
            }
        }

        public static Dron DodijeliPocetniPolozajDrona(Point lokacija)
        {
            Dron dron = new Dron();
            dron.Location = lokacija;
            return dron;
        }
    }
}
