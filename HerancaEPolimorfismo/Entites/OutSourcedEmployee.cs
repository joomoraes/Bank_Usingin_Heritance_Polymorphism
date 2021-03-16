using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entites
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

        public OutSourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour)
            :base( name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
