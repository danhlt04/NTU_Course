using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class Printer
    {
        protected string NhaSanXuat;
        protected long Gia;

        public long Price
        {
            get { return Gia; }
            set { Gia = value; }
        }

        public string NXS
        {
            get { return NhaSanXuat; }
            set { NhaSanXuat = value; }
        }

        public Printer() { }

        public Printer(string NhaSanXuat, long Gia)
        {
            this.NhaSanXuat = NhaSanXuat;
            this.Gia = Gia;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap nha san xuat: ");
            NhaSanXuat = Console.ReadLine()!;
            Console.Write("Nhap gia: ");
            Gia = long.Parse(Console.ReadLine()!);
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Nha san xuat: {NhaSanXuat}");
            Console.WriteLine($"Gia ban: {Gia}");
        }
    }
}
