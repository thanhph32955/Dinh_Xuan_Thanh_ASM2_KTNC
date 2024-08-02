using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class TinhTBCCua1List
    {
        public double TinhTBCCuaList(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            double sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            return sum / list.Count;
        }

    }
}
