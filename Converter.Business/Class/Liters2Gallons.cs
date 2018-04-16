using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Business.Class
{
    public class Liters2Gallons
    {
         char choice;
         double measurement;

        public double Convert(char choice, double measurement)
        {
            this.choice = choice;
            this.measurement = measurement;
            char measurelowercase = char.ToLower(this.choice);
            switch (measurelowercase)
            {
                // from liter
                case 'l':
                    double gallons = (this.measurement / 3.78541);
                    this.measurement = gallons;
                    break;

                // from gallons
                case 'g':
                    double liter = (this.measurement * 3.78541);
                    this.measurement = liter;
                    break;
            }
            return this.measurement;
        }
    }
}
