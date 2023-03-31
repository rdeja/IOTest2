using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTest2
{
    public class CRect
    {
        private int w;
        private int h;
        public CRect(int w, int h)
        {
            this.w = w;
            this.h = h;
        }

        public int Area()
        {
            return w * h;
        }
    }
}
