using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PhanSo
{
    internal class Fractor
    {
        private int _tuSo;
        private int _mauSo;

        public int tuso {
            get { return _tuSo; } 
            set { _tuSo = value; }
        }
        public int mauso { 
            get { return _mauSo; } 
            set
            {
                if (value == 0) Console.WriteLine("Mau so khong the bang 0!");
                else _mauSo = value;
            }
        }

        public Fractor() { }

        public Fractor(int ts, int ms)
        {
            _tuSo = ts;
            _mauSo = ms;
        }

        public Fractor(Fractor p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }

        public void Input()
        {
            Console.Write("Nhap tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so: ");
                int.TryParse(Console.ReadLine(), out _mauSo);
            } while (_mauSo == 0);
        }

        public void Output()
        {
            Console.WriteLine($"{_tuSo}/{_mauSo}");
        }

        public void ReducingFractor()
        {
            int gcd = GCD(_tuSo, _mauSo);
            _tuSo /= gcd;
            _mauSo /= gcd;
            if(_mauSo < 0)
            {
                _tuSo *= -1;
                _mauSo *= -1;
            }
        } 

        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        public static Fractor operator + (Fractor a, Fractor b)
        {
            Fractor Sum = new Fractor();
            Sum._tuSo = a._tuSo * b._mauSo + a._mauSo * b._tuSo;
            Sum._mauSo = a._mauSo * b._mauSo;
            return Sum;
        }

        public static Fractor operator - (Fractor a, Fractor b)
        {
            Fractor Diff = new Fractor();
            Diff._tuSo = a._tuSo * b._mauSo - a._mauSo * b._tuSo;
            Diff._mauSo = a._mauSo * b._mauSo;
            return Diff;
        }
    }
}