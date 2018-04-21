using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{
    class CVector2
    {
        private int theX;
       public int theY;
        public CVector2()
        {
            theX = 0;
            theY = 0;
        }
        public int x
        {
            get
            {
                return theX;
            }
            set
            {
                theX = value;
            }
        }
        public int Y
        {
            get;
            set;
        }
    }
}
