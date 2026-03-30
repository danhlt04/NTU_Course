using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    internal class Circle : HinhVe
    {
        private int R;

        public Circle() : base() { }

        public Circle(int R)
        {
            this.R = R;
        }

        public override void TinhDienTich()
        {
            DienTich = R * R * Math.PI;
        }

        public override void Info()
        {
            Console.WriteLine($"Dien tich hinh tron la: {DienTich:F2}");
        }
    }
}
