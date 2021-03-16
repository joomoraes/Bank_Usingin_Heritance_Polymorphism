using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entites
{
    class Employee
    {
        //JAVA
        private string name;
        private int hour;

        public Employee(string Name, int Hour)
        {
            this.Name = name;
            this.hour = Hour;
        }

        public string getName()
        {
            return name;
        }

        public void Setname(string name)
        {
            name = Name;
        }

        // 888888
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
