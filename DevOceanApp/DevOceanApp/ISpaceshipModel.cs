using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public interface ISpaceshipModel
    {
        string Type { get; }
        int DeclinedTaxForUsingPerYear { get; }
        int IncreasesTaxForThousandMilesTravel { get; }
        int InitialTax { get; }

        string GetType();
    }
}
