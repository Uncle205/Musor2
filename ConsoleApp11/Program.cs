using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car user = new Car()
            {
                Model = "SX150",
                Price = "200000",
                Name = "Vertygo"
            };

            Type type = typeof(Car);

            Console.WriteLine("Type is: {0}", type.Name);
            PropertyInfo[] property = type.GetProperties();

            Console.WriteLine("Properties (N = {0}):",
                              property.Length);

            foreach (var proper in property)
                if (proper.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", proper.Name,
                                      proper.PropertyType.Name,
                                      proper.GetValue(user, null));

            Console.ReadLine();
        }
    }
}
