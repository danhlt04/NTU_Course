using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong xe: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            List<XeCon> li = new List<XeCon>();
            for (int i = 0; i < n; i++)
            {
                XeCon x = new XeCon();
                x.Nhap();
                li.Add(x);
            }
            //Console.WriteLine("Danh sach xe da nhap:");
            //foreach (XeCon x in li) x.Xuat();
            //Console.WriteLine($"Gia xe cao nhat la: {GiaLonNhat(li)}");
            //Console.WriteLine($"Gia xe thap nhat la: {GiaNhoNhat(li)}");
            //Console.Write("Nhap bien so can tim: ");
            //string bs = Console.ReadLine()!;
            //TimXe(li, bs);
            SapXepNamTangDan(li);
        }

        static int GiaLonNhat(List<XeCon> li)
        {
            int ans = 0;
            foreach (XeCon x in li) ans = Math.Max(ans, x.GiaXe);
            return ans;
        }

        static int GiaNhoNhat(List<XeCon> li)
        {
            int ans = 100000000;
            foreach (XeCon x in li) ans = Math.Min(ans, x.GiaXe);
            return ans;
        }

        static void TimXe(List<XeCon> li, string bs)
        {
            foreach(XeCon x in li)
            {
                if (bs == x.BienSoXe.Substring(2)) x.Xuat();
            }
        }

        static void SapXepNamTangDan(List<XeCon> li)
        {
            li.Sort((x, y) => x.NamSanXuatXe.CompareTo(y.NamSanXuatXe));
            Console.WriteLine("Danh sach xe sau khi sap xep:");
            foreach (XeCon x in li) x.Xuat();  
        }
    }
}
