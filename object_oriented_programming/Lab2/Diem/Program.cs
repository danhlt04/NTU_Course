using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace Diem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //do
            //{
            //    Console.Write("Nhap so luong diem: ");
            //    int.TryParse(Console.ReadLine(), out n);
            //} while (n <= 0);
            //Point[] points = new Point[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap x: ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap y: ");
            //    int y = int.Parse(Console.ReadLine());
            //    points[i] = new Point(x, y);
            //}
            //Console.WriteLine("Cac diem da nhap la");
            //for (int i = 0; i < n; i++) Console.WriteLine($"({points[i].X}, {points[i].Y})");
            //Point p = MaxOfDis(points);
            //Console.WriteLine($"Diem cach xa goc toa do nhat la: ({p.X}, {p.Y})");
            //NearOfPoint(points);

            Console.WriteLine("Nhap thong tin hinh tron");
            Console.Write("Ban kinh hinh tron: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Toa do tam hinh tron:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Point c = new Point(x, y);
            Circle a = new Circle(r, c);
            Console.WriteLine($"Dien tich hinh tron: {a.Area():F2}");
            Console.WriteLine("Di chuyen hinh tron toi mot diem:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            a.Move(x, y);
            Console.WriteLine($"Toa do tam hinh tron sau khi di chuyen la: ({a.C.X}, {a.C.Y})");

            Circle b = new Circle(5, new Point(10, 2));
            Console.WriteLine($"Dien tich hinh tron: {b.Area():F2}");
            Console.WriteLine("Di chuyen hinh tron toi mot diem:");
            b.Move(4, -6);
            Console.WriteLine($"Toa do tam hinh tron sau khi di chuyen la: ({b.C.X}, {b.C.Y})");

            Circle d = new Circle(8, new Point(-2, 5));
            Console.WriteLine($"Dien tich hinh tron: {d.Area():F2}");
            Console.WriteLine("Di chuyen hinh tron toi mot diem:");
            d.Move(18, 7);
            Console.WriteLine($"Toa do tam hinh tron sau khi di chuyen la: ({d.C.X}, {d.C.Y})");
        }

        public static Point MaxOfDis(Point[] points)
        {
            Point ans = new Point();
            double maxdis = 0;
            foreach(Point p in points)
            {
                double curdis = p.Distance();
                if(curdis > maxdis)
                {
                    maxdis = curdis;
                    ans = p;
                }
            }
            return ans;
        }

        public static void NearOfPoint(Point[] points)
        {
            Point pa = new Point();
            Point pb = new Point();
            double d = 1000000;
            for(int i = 0; i < points.Length; i++)
            {
                for(int j = 0; j < points.Length; j++)
                {
                    if (i == j) continue;
                    Point p = new Point(points[i].X - points[j].X, points[i].Y - points[j].Y);
                    double a = p.Distance();
                    if(a < d)
                    {
                        d = a;
                        pa = points[i];
                        pb = points[j];
                    }
                }
            }
            Console.WriteLine($"Hai diem gan nhau nhat la: ({pa.X}, {pa.Y}) ({pb.X}, {pb.Y})");
        }
    }
}
