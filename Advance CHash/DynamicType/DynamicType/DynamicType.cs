using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
    internal class DynamicType
    {
        /// <summary>
        /// Dynamic Type Change Types at run time  based on  assigned value
        /// </summary>
        static void Main()
        {
            dynamic name = "Venkat";

            Console.WriteLine("Value : " + name + " Type : " + name.GetType());

            name = 15;
            Console.WriteLine("\nValue : " + name + " Type : " + name.GetType());

            name = DateTime.Now;
            Console.WriteLine("\nValue : " + name + " Type : " + name.GetType());

            name = true;
            Console.WriteLine("\nValue : " + name + " Type : " + name.GetType());
        }
    }
}
