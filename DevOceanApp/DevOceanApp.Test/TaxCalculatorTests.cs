using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOceanApp;
using Xunit;

namespace DevOceanApp.Test
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void CalculateTaxToResult_CalculateResult()
        {
            int expected = 326768;

            //Family spaceship bought in 2300 has traveled 2_344 light miles, so in 2307 owes:
            //5_000 + 2 * 100 - 7 * 355

            //Cargo spaceship bought in 2332 has traveled 344_789 light miles, so in 2369 owes:
            //10_000 + 344 * 1_000 - (2369 - 2332) * 736
            int actual = TaxCalculator.CalculateTaxToResult(10000, 344, 1000, 2369, 2332, 736);

            Assert.Equal(expected, actual);
        }
    }
}
