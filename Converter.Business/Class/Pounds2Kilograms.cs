using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Business.Class
{
    public class Pounds2Kilograms
    {
         char choice;
         double measurement;
        
        public double Convert(char choice, double measurement) {
            this.choice = choice;
            this.measurement = measurement;
            char measurelowercase = char.ToLower(choice);
            switch (measurelowercase)
            {

                // from pounds
                case 'p':
                    double kilograms = (measurement / 2.2);
                    this.measurement = kilograms;
                    break;

                // from kilograms
                case 'k':
                    double pounds = (measurement * 2.2);
                    this.measurement = pounds;
                    break;
            }
            return this.measurement;
        }
    }
}

