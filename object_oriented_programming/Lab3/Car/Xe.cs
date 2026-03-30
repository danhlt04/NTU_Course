using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    internal class Xe
    {
        protected string BienSo;
        protected int NamSanXuat;
        protected int Gia;

        public string BienSoXe
        {
            get { return BienSo; }
            set { BienSo = value; }
        }

        public int NamSanXuatXe
        {
            get { return NamSanXuat; }
            set { NamSanXuat = value; }
        }

        public int GiaXe
        {
            get { return Gia; }
            set { Gia = value; }
        }

        public Xe()
        {
            BienSo = "";
            NamSanXuat = 0;
            Gia = 0;
        }

        public Xe(string BienSo, int NamSanXuat, int Gia)
        {
            this.BienSo = BienSo;
            this.NamSanXuat = NamSanXuat;
            this.Gia = Gia;
        }

        public void Nhap()
        {
            Console.Write("Nhap bien so: ");
            BienSo = Console.ReadLine()!;
            Console.Write("Nhap nam san xuat: ");
            NamSanXuat = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap gia: ");
            Gia = int.Parse(Console.ReadLine()!);
        }

        public void Xuat()
        {
            Console.WriteLine($"Bien so: {BienSo}");
            Console.WriteLine($"Nam san xuat: {NamSanXuat}");
            Console.WriteLine($"Gia: {Gia}");
        }

    }
}
