using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTuong
{
    class IndexArray
    {
        int i;
        int j;
        Object tag;
        public int I { get => i; set => i = value; }
        public int J { get => j; set => j = value; }
        public object Tag { get => tag; set => tag = value; }

        public IndexArray(int i,int j)
        {
            I = i;
            J = j;
        }
        public IndexArray(int i)
        {
            I = i;
            j = 0;
        }
    }
}
