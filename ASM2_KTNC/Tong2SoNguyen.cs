using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Tong2SoNguyen
    {
        public int Tong(int a, int b)
        {
            return a + b;
        }

        public bool KiemTraSoNguyen(object a, object b)
        {
            if (a is int && b is int)
            {
                return true;
            }
            return false;
        }
       
    }
}
