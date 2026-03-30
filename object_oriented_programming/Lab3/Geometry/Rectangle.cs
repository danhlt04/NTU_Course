using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    internal class Rectangle : HinhVe 
    {
        protected int Width;
        protected int Height;

        public Rectangle() : base() { }

        public Rectangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override void TinhDienTich()
        {
            DienTich = 1.0 * Width * Height;
        }

        public override void Info()
        {
            Console.WriteLine($"Dien tich hinh chu nhat la: {DienTich:F2}");
        }
    }
}
