using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class TruyXuatPhanTuMang
    {
        public int TruyXuat(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Number is out of range for the array.");
            }
            return array[index];
        }
    }
}
