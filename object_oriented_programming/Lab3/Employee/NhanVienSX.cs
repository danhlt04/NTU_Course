using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class NhanVienSX : NhanVien
    {
        private long LuongCB;
        private int SoSP;

        public NhanVienSX() : base() { }

        public NhanVienSX(string HoTen, string NgaySinh, long LuongCB, int SoSP) : base(HoTen, NgaySinh)
        {
            this.LuongCB = LuongCB;
            this.SoSP = SoSP;
        }

        public override void TinhLuong()
        {
            LNV = LuongCB + SoSP * 5000;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            LuongCB = long.Parse(Console.ReadLine()!);
            Console.Write("Nhap so san pham: ");
            SoSP = int.Parse(Console.ReadLine()!);
        }

        public override void Info()
        {
            base.Info();
        }
    }
}
