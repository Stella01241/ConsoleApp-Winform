using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tryoo.Model;

namespace Tryoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer();
            Laptop laptop = new Laptop();
            PC pc = new PC();
            ASUS_Laptop asus = new ASUS_Laptop();
            //強制轉型
            Computer temp1 = (Computer)asus;
            //as轉型
           // Computer temp2 = laptop as Computer;
           
           
            if(temp1 is Laptop)
            {
                if (temp1 is ASUS_Laptop)
                {
                    Console.WriteLine("Temp1 is ASUS_Laptop");
                }
                else
                {
                    Console.WriteLine("Temp1 is Laptop");
                }
            }
            else
            {
                Console.WriteLine("Temp1 is not laptop");
            
            }
            Type typeOfclass = typeof(ASUS_Laptop);
            Console.WriteLine(typeOfclass);
            Type typeOfInstance = temp1.GetType();
            Console.WriteLine(typeOfInstance);

            if (typeOfclass==typeOfInstance)
            {

            }
            temp1.CPU = "Intel i7";
            pc.CPU = "Intel i7";
            asus.CPU = "Intel i7";
            temp1.GetName();
            pc.GetName();
            asus.GetName();
           // laptop.Monitor = "ViewSonic";
          //  ASUS_Laptop.Monitor = "ViewSonic";

            Console.ReadLine();
        }
    }
}
