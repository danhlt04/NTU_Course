using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    internal class NhanVien
    {
        protected string HoTen;
        protected string NgaySinh;
        protected long LuongNhanVien;

        public long LNV   
        {
            get { return LuongNhanVien; } 
            set { LuongNhanVien = value; }
        }

        public NhanVien() { }

        public NhanVien(string HoTen, string NgaySinh)
        {
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
        }

        public virtual void TinhLuong() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine()!;
            Console.Write("Nhap ngay sinh: ");
            NgaySinh = Console.ReadLine()!;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{HoTen} {NgaySinh} {LuongNhanVien}");
        }
    }
}
