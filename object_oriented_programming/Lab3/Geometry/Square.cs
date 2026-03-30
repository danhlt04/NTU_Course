using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    internal class Square : Rectangle 
    {
        private int E;

        public Square() : base() { }

        public Square(int E)
        {
            this.E = E;
        }

        public override void TinhDienTich()
        {
            DienTich = E * E;
        }

        public override void Info()
        {
            Console.WriteLine($"Dien tich hinh vuong la: {DienTich:F2}");
        }
    }
}
