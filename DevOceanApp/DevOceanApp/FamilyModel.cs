using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public class FamilyModel : ISpaceshipModel
    {
        private readonly string _type = "Family";
        private readonly int _initialTax = 5000;

        // Family – for every 1_000 light miles traveled, the tax increases by 100 DVS
        private readonly int _increasesTaxForThousandMilesTravel = 1000;

        //For every year the spaceship is used, the tax declines:  
        // Family – declines every year by 355 DVS
        private readonly int _declinedTaxForUsingPerYear = 355;

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
