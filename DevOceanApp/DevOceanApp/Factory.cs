using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOceanApp
{
    public static class Factory
    {
        public static ISpaceshipModel CreateCargoModel()
        {
            return new CargoModel();
        }

        public static ISpaceshipModel CreateFamilyModel()
        {
            return new FamilyModel();
        }
    }
}
