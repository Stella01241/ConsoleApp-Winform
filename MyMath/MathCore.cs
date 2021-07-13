using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try.MyMath
{
    public class MathCore
    {
        public static double Pow(double baseNumber,double powNumber)
        {
            //Obj2.Exec();
            Obj2.Exec2();
            Obj2.Exec3();
            return Math.Pow(baseNumber,powNumber);
        }
    }
    public class Obj2
    {
        private static void Method2()
        {
            Exec();
            Exec2();
            Exec3();
        }
        private static void Exec() { }
        internal static void Exec2() { }
        public static void Exec3() { }

    }
}
