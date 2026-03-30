using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Employee
{
    internal class NhanVienVP : NhanVien
    {
        private int SoNgay;

        public NhanVienVP() : base() { }

        public NhanVienVP(string HoTen, string NgaySinh, int SoNgay) : base(HoTen, NgaySinh)
        {
            this.SoNgay = SoNgay;
        }
        public override void TinhLuong()
        {
            LNV = SoNgay * 100000;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ngay lam viec: ");
            SoNgay = int.Parse(Console.ReadLine()!);
        }

        public override void Info()
        {
            base.Info();
        }
    }
}
