using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPartialClass tmpPc = new CPartialClass();
            Console.WriteLine(tmpPc.theModule1);
            Console.WriteLine(tmpPc.theModule2);
            Console.WriteLine(tmpPc.FunctionA());
            Console.WriteLine(tmpPc.FunctionB());

            CVector2 tmpV2 = new CVector2();
            tmpV2.x = 3;
            Console.WriteLine(tmpV2.x);
            tmpV2.Y = 7;
            Console.WriteLine(tmpV2.Y);

            var tmpStudent = new { Number = 1, Name = "Mirim" };
            Console.WriteLine(tmpStudent.Number);
            Console.WriteLine(tmpStudent.Name);
        }
       partial class CPartialClass
        {
            public CPartialClass()
            {
                theModule1 = 5;
                theModule2 = 3;
            }
            public int theModule2;
            public int FunctionB()
            {
                return 2;
            }
        }
       
    }
}
