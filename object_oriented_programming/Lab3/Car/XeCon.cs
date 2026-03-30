using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    internal class XeCon : Xe
    {
        private int SoChoNgoi;
        private string LoaiXe;

        public XeCon() : base()
        {
            SoChoNgoi = 0;
            LoaiXe = "";
        }
        public XeCon(string BienSo, int NamSanXuat, int Gia, int SoChoNgoi, string LoaiXe) : base(BienSo, NamSanXuat, Gia)
        {
            this.SoChoNgoi = SoChoNgoi;
            this.LoaiXe = LoaiXe;
        }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap loai xe: ");
            LoaiXe = Console.ReadLine()!;
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}");
            Console.WriteLine($"Loai xe: {LoaiXe}");
        }
    }
}
