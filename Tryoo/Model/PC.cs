using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tryoo.Model;

namespace Tryoo.Model
{
    class Computer
    {
        public string CPU;
        public string GetName()
        {
            return"";
        }
        private string _power;
        public string Power
        {
            get { return  this._power; }
             private set { this._power = value; }

        }
        public string Power2 { get; }
        public string Power3 { set { this._power = value; } }
        //public void SetPower(string value )
        //{
        //    this._power = value;
        //}
        //public string Power { get; set; }
    }
    class PC : Computer
    {

    }
    class Laptop : Computer
    {
        public Laptop()
        {
            this.Monitor = this.GetName();
        }
        public Laptop(int no)
        {
            this.Monitor = this.GetName() + no;
        }
        ~Laptop()
        {

        }
        public string Monitor;
    }
    class ASUS_Laptop : Laptop
    {
        public ASUS_Laptop() : base(0)
        {
            
        }
        public ASUS_Laptop(int no ): base(no)
        {

        }
    }

}
