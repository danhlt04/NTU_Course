namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhVe a = new Rectangle(3, 4);
            HinhVe b = new Circle(10);
            HinhVe c = new Square(5);

            a.TinhDienTich();
            b.TinhDienTich();
            c.TinhDienTich();

            a.Info();
            b.Info();
            c.Info();
        }
    }
}
