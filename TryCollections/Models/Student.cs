using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCollections.Models
{
    class Student
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string GetText()
        {
            string result =
                $"No:{this.No},Name:{this.Name},ClassName:{this.ClassName}";
            return result;
        }
    }
}
