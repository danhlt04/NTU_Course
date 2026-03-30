namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong may in laser: ");
                int.TryParse(Console.ReadLine()!, out n);
            } while (n <= 0);
            Printer[] printers = new LaserPrinter[n];
            for(int i = 0; i < n; i++)
            {
                printers[i] = new LaserPrinter();
                printers[i].Nhap();
            }
            for(int i = 0; i < n; i++)
            {
                printers[i].Xuat();
            }
            Console.WriteLine($"Gia may in laser lon nhat la: {GiaLonNhat(printers, n)}");
            Console.WriteLine($"Gia may in laser nho nhat la: {GiaNhoNhat(printers, n)}");
            InTheoHang(printers, n);
            SapXepTangDan(printers, n);
            Console.WriteLine("Danh sach may in sau khi sap xep: ");
            for(int i = 0; i < n; i++)
            {
                printers[i].Xuat();
            }
        }

        static long GiaLonNhat(Printer[] printers, int n)
        {
            long ans = printers[0].Price;
            for(int i = 0; i < n; i++)
            {
                ans = Math.Max(ans, printers[i].Price);
            }
            return ans;
        }

        static long GiaNhoNhat(Printer[] printers, int n)
        {
            long ans = printers[0].Price;
            for (int i = 0; i < n; i++)
            {
                ans = Math.Min(ans, printers[i].Price);
            }
            return ans;
        }

        static void InTheoHang(Printer[] printers, int n)
        {
            Console.Write("Nhap hang may in can tim: ");
            string Hang = Console.ReadLine();
            for(int i = 0; i < n; i++)
            {
                if (Hang == printers[i].NXS)
                {
                    printers[i].Xuat();
                }
            }
        }

        static void SapXepTangDan(Printer[] printers, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (printers[j].Price > printers[j + 1].Price)
                    {
                        Printer tmp = new LaserPrinter();
                        tmp = printers[j];
                        printers[j] = printers[j + 1];
                        printers[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
