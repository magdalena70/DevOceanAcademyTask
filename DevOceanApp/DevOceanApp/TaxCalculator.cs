using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public class TaxCalculator
    {
        public static int CalculateTaxToResult(int initialTax, int lightMilesTraveled,
                                                     int increasesTaxForThousandMilesTravel,
                                                     int yearOfTaxCalculation, int yearOfPurchase,
                                                     int declinedTaxForUsingPerYear)
        {
            int result = initialTax + lightMilesTraveled * increasesTaxForThousandMilesTravel -
                                    (yearOfTaxCalculation - yearOfPurchase) * declinedTaxForUsingPerYear;

            return result;
        }

        public static void CalculateCargoTax()
        {
            ISpaceshipModel cargo = Factory.CreateCargoModel();
            int initialTax = cargo.InitialTax;
            int increasesTaxForThousandMilesTravel = cargo.IncreasesTaxForThousandMilesTravel;
            int declinedTaxForUsingPerYear = cargo.DeclinedTaxForUsingPerYear;

            int lightMilesTraveled = GetInputValues.GetLightMilesTraveled();
            int yearOfPurchase = GetInputValues.GetYearOfPurchase();
            int yearOfTaxCalculation = GetInputValues.GetYearOfTaxCalculation(yearOfPurchase);

            int cargoTaxInteger = CalculateTaxToResult(initialTax, lightMilesTraveled,
                                                          increasesTaxForThousandMilesTravel,
                                                          yearOfTaxCalculation, yearOfPurchase,
                                                          declinedTaxForUsingPerYear);


            string cargoTaxStr = String.Format("{0} + {1} * {2} - ( {3} - {4} ) * {5}",
                                                initialTax, lightMilesTraveled,
                                                increasesTaxForThousandMilesTravel,
                                                yearOfTaxCalculation, yearOfPurchase,
                                                declinedTaxForUsingPerYear);

            Console.WriteLine();
            Console.WriteLine("Calculate values: " + cargoTaxStr);
            Console.WriteLine();
            Console.WriteLine("Result: " + cargoTaxInteger + " DVS");
        }

        public static void CalculateFamilyTax()
        {
            ISpaceshipModel family = Factory.CreateFamilyModel();
            int initialTax = family.InitialTax;
            int increasesTaxForThousandMilesTravel = family.IncreasesTaxForThousandMilesTravel;
            int declinedTaxForUsingPerYear = family.DeclinedTaxForUsingPerYear;

            int lightMilesTraveled = GetInputValues.GetLightMilesTraveled();
            int yearOfPurchase = GetInputValues.GetYearOfPurchase();
            int yearOfTaxCalculation = GetInputValues.GetYearOfTaxCalculation(yearOfPurchase);

            int familyTaxInteger = CalculateTaxToResult(initialTax, lightMilesTraveled,
                                                          increasesTaxForThousandMilesTravel,
                                                          yearOfTaxCalculation, yearOfPurchase,
                                                          declinedTaxForUsingPerYear);


            string familyTaxStr = String.Format("{0} + {1} * {2} - ( {3} - {4} ) * {5}",
                                                initialTax, lightMilesTraveled,
                                                increasesTaxForThousandMilesTravel,
                                                yearOfTaxCalculation, yearOfPurchase,
                                                declinedTaxForUsingPerYear);

            Console.WriteLine();
            Console.WriteLine(" Calculate values: " + familyTaxStr);
            Console.WriteLine();
            Console.WriteLine(" Result: " + familyTaxInteger + " DVS");
        }
    }
}   


