using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul15
{
    class Program
    {
        static void Main(string[] args)
        {
                Person person = new Person()
                {
                    Name = "Malika",
                    Age = 18,
                    City = "Astana"
                };
                Type type = typeof(Person);
                Console.WriteLine("Тип: " + type.Name);
                PropertyInfo[] properties = type.GetProperties();
                Console.WriteLine("Методы: ");
                foreach (var property in properties)
                {
                    Console.WriteLine(property.PropertyType + ":\t" + property.Name);
                }
                Console.Read();
         }
     }
}