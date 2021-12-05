using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DevOceanApp
{
    public class Printer
    {
        public static void PrintTax()
        {
            string modelType = GetInputValues.GetModelType();
            System.Globalization.TextInfo type = new System.Globalization
                .CultureInfo("en-US", false)
                .TextInfo;
            modelType = type.ToTitleCase(modelType);

            switch (modelType)
            {
                case "Cargo":
                    TaxCalculator.CalculateCargoTax();
                    break;
                case "Family":
                    TaxCalculator.CalculateFamilyTax();
                    break;
                default:
                    Console.WriteLine("Incorect spaceship type");
                    break;
            }
            Console.WriteLine("Press 'Enter' to exit..");
        }

      
    }
}
