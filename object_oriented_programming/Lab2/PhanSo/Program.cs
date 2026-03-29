namespace PhanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fractor a = new Fractor();
            //Fractor b = new Fractor();

            //a.Input();
            //b.Input();

            //a.Output();
            //b.Output();

            //Console.WriteLine("Phan so sau khi toi gian");
            //a.ReducingFractor();
            //b.ReducingFractor();
            //a.Output();
            //b.Output();

            //Console.WriteLine("Tong hai phan so");
            //Fractor c = a + b;
            //c.ReducingFractor();
            //c.Output();

            //Console.WriteLine("Hieu hai phan so");
            //Fractor d = a - b;
            //d.ReducingFractor();
            //d.Output();

            int size;
            do
            {
                Console.Write("Nhap so luong mang phan so: ");
                int.TryParse(Console.ReadLine(), out size);
            } while (size <= 0);
            ListOfFractor LF = new ListOfFractor(size);
            LF.InputArr();
            Console.WriteLine("Danh sach phan so vua nhap");
            LF.OutputArr();
            Fractor MaxF = LF.MaxOfFractorArray();
            Console.WriteLine($"Phan so lon nhat trong mang la: {MaxF.tuso}/{MaxF.mauso}");
            Console.WriteLine("Danh sach phan so sau khi sap xep");
            LF.BubbleSort();
            LF.OutputArr();
        }
    }
}
