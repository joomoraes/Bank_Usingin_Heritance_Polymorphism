using System;
using HerancaEPolimorfismo.Entites;
using System.Collections.Generic;
using System.Globalization

namespace HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.WriteLine("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(additionalCharge, name, hours, valuePerHour));
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InstalledUICulture));
            }
        }
    }
}
