using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class LaserPrinter : Printer
    {
        private string DPI;

        public LaserPrinter() : base() { }

        public LaserPrinter(string NhaSanXuat, long Gia, string DPI) : base(NhaSanXuat, Gia)
        {
            this.DPI = DPI;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap do phan giai: ");
            DPI = Console.ReadLine()!;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Do phan giai : {DPI}");
        }
    }
}
