using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department root = GenerateDepartments();
            PrintNodeAndSubNode(root);
            Console.ReadLine();
        }

         public class Department
        {
            public string Name { get; set; }
            public List<Department> Children { get; set; }
        }

        public static Department GenerateDepartments()
        {
            Department root = new Department()
            {
                Name = "總經理室",
            };

            Department node2_1 = new Department() { Name = "生產",};
            Department node2_2 = new Department() { Name = "銷售", };
            root.Children = new List<Department>() { node2_1, node2_2 };

            Department node3_1 = new Department() { Name = "生產", };
            Department node3_2 = new Department() { Name = "銷售", };
            node2_1.Children = new List<Department>() { node3_1, node3_2 };


            Department node4_1 = new Department() { Name = "生產", };
            Department node4_2 = new Department() { Name = "銷售", };
            node3_2.Children = new List<Department>() { node4_1, node4_2 };

            return root;
        }

        public static void PrintNodeAndSubNode(Department dept)
        {
            if (dept == null)
                return;
            Console.WriteLine(dept.Name);

            if (dept.Children == null || dept.Children.Count == 0)
                return;
            foreach(Department subDept in dept.Children)
            
                PrintNodeAndSubNode(subDept);
            
        }
    }
}
