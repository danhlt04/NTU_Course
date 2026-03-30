using System.Numerics;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong nhan vien: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            NhanVien[] NV = new NhanVien[n];
            for(int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine()!);
                if(t == 1)
                {
                    NhanVienVP VP = new NhanVienVP();
                    VP.Nhap();
                    NV[i] = VP;
                    NV[i].TinhLuong();
                } else
                {
                    NhanVienSX SX = new NhanVienSX();
                    SX.Nhap();
                    NV[i] = SX;
                    NV[i].TinhLuong();
                }
            }
            for(int i = 0; i < n; i++) NV[i].Info();
            SapXepLuong(NV, n);
            for (int i = 0; i < n; i++) NV[i].Info();
        }

        static void SapXepLuong(NhanVien[] NV, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (NV[j].LNV < NV[j + 1].LNV)
                    {
                        NhanVien tmp = new NhanVien();
                        tmp = NV[j];
                        NV[j] = NV[j + 1];
                        NV[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
