using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Business.Class
{
    public class Farenheit2Celsius
    {
         char choice;
         double temperature;

        public double Convert(char choice, double temp)
        {
            this.choice = choice;
            this.temperature = temp;
            char templowercase = char.ToLower(choice);
            switch (templowercase)
            {
                // from farenheit
                case 'f':
                    double celsius = (temperature - 32) / 1.8;
                    this.temperature = celsius;
                    break;

                // from celsius
                case 'c':
                    double farenheit = (temperature * 1.8) + 32;
                    this.temperature = farenheit;
                    break;
            }
            return temperature;
        }
    }
}
