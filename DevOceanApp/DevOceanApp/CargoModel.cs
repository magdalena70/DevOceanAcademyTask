using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public class CargoModel : ISpaceshipModel
    {
        private readonly string _type = "Cargo";

        private readonly int _initialTax = 10000;
        // Cargo – for every 1_000 light miles traveled, the tax increases by 1_000 DVS
        private readonly int _increasesTaxForThousandMilesTravel = 100;

        //For every year the spaceship is used, the tax declines:  
        // Cargo – declines every year by 736 DVS
        private readonly int _declinedTaxForUsingPerYear = 736;

        public string GetType()
        {
            return _type;
        }

        public string Type
        {
            get { return _type; }
        }

        public int InitialTax
        {
            get { return _initialTax; }
        }

        public int IncreasesTaxForThousandMilesTravel
        {
            get { return _increasesTaxForThousandMilesTravel; }
        }

        public int DeclinedTaxForUsingPerYear
        {
            get { return _declinedTaxForUsingPerYear; }
        }
    }
}
