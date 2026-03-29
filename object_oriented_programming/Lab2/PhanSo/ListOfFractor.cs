using System;
using System.Collections.Generic;
using System.Drawing;
using System.Formats.Asn1;
using System.Text;

namespace PhanSo
{
    internal class ListOfFractor
    {
        private Fractor[] _dsPS;
        private int _size;

        public ListOfFractor(int size) {
            _size = size;
            _dsPS = new Fractor[_size];
        }

        public void InputArr()
        {
            for (int i = 0; i < _size; i++)
            {
                _dsPS[i] = new Fractor();
                _dsPS[i].Input();
                _dsPS[i].ReducingFractor();
            }
        }

        public void OutputArr()
        {
            foreach (Fractor f in _dsPS) f.Output();
        }

        public Fractor MaxOfFractorArray()
        {
            Fractor ans = _dsPS[0];
            foreach(Fractor f in _dsPS)
            {
                double a = 1.0 * ans.tuso / ans.mauso;
                double b = 1.0 * f.tuso / f.mauso;
                if (a < b) ans = f;
            }
            return ans;
        }

        public void BubbleSort()
        {
            for(int i = 0; i < _size - 1; i++)
            {
                for(int j = 0; j < _size - i - 1; j++)
                {
                    double a = _dsPS[j].tuso / _dsPS[j].mauso;
                    double b = _dsPS[j + 1].tuso / _dsPS[j + 1].mauso;
                    if(a > b)
                    {
                        Fractor tmp = newFractor();
                        tmp = _dsPS[j];
                        _dsPS[j] = _dsPS[j + 1];
                        _dsPS[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
