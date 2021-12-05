using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public class GetInputValues
    {
        public static string GetModelType()
        {
            Console.WriteLine("Select type 'Cargo' or type 'Family' and press 'Enter'");
            string type = Console.ReadLine();
            return type;
            
        }

        public static int GetYearOfPurchase() 
        {
            Console.WriteLine("Set year of purchase > = 2300 and press 'Enter'");
            string yearOfPurchaseStr = Console.ReadLine();
            int yearOfPurchase;
            if (int.TryParse(yearOfPurchaseStr, out yearOfPurchase))
            {
                yearOfPurchase = Int32.Parse(yearOfPurchaseStr);

                if (yearOfPurchase < 2300)
                {
                    Console.WriteLine("Incorect year of purchase: " + yearOfPurchase);
                    Console.WriteLine("year of purchase will be = 2300");
                    yearOfPurchase = 2300;
                }
            }
            else
            {
                Console.WriteLine("Incorect year of purchase: " + yearOfPurchase);
                Console.WriteLine("year of purchase will be = 2300");
                yearOfPurchase = 2300;
            }
            
            return yearOfPurchase;

        }

        public static int GetYearOfTaxCalculation(int yearOfPurchase)
        {
            Console.WriteLine("Set year of tax calculation > = year of purchase and press 'Enter'");
            string yearOfTaxCalculationStr = Console.ReadLine();

            int yearOfTaxCalculation;
            if (int.TryParse(yearOfTaxCalculationStr, out yearOfTaxCalculation))
            {
                yearOfTaxCalculation = Int32.Parse(yearOfTaxCalculationStr);
                if (yearOfTaxCalculation < yearOfPurchase)
                {
                    Console.WriteLine("Incorect year of tax calculation: " + yearOfTaxCalculation);
                    Console.WriteLine("year of tax calculation will be = " + yearOfPurchase);
                    yearOfTaxCalculation = yearOfPurchase;
                }
            }
            else
            {
                Console.WriteLine("Incorect year of tax calculation " + yearOfTaxCalculation);
                Console.WriteLine("year of tax calculation will be = " + yearOfPurchase);
                yearOfTaxCalculation = yearOfPurchase;
            }

            return yearOfTaxCalculation;
        }

        public static int GetLightMilesTraveled()
        {
            Console.WriteLine("Set light miles traveled > = 1000 and press 'Enter'");
            string lightMilesTraveledStr = Console.ReadLine().Replace("_", "");

            int lightMilesTraveled;
            if (int.TryParse(lightMilesTraveledStr, out lightMilesTraveled))
            {
                lightMilesTraveled = Int32.Parse(lightMilesTraveledStr);
                if (lightMilesTraveled < 1000)
                {
                    Console.WriteLine("Incorect light miles traveled:");
                    Console.WriteLine("light miles traveled  will be = " + 0);
                    lightMilesTraveled = 0;
                }
                else
                {
                    lightMilesTraveled = lightMilesTraveled / 1000;
                }
            }
            else
            {
                Console.WriteLine("Incorect light miles traveled  " + lightMilesTraveled);
                Console.WriteLine("light miles traveled  will be = " + 0);
                lightMilesTraveled = 0;
            }

            return lightMilesTraveled;
        }

    }
}
