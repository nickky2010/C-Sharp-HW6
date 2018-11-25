using System;

namespace HW6_1.Tarifs
{
    class PreferentialTariffTwo :Tariff
    {
        int freeLimit;
        public int FreeLimit
        {
            get => freeLimit;
            set
            {
                if (value > 0)
                {
                    freeLimit = value;
                }
                else
                    throw new Exception("Должны быть бесплатные киловатты");
            }
        }
        public PreferentialTariffTwo (decimal energyPrice = 0.15m, int freeLimit=50):base(energyPrice)
        {
            FreeLimit = freeLimit;
        }
        public override decimal GetTotalCost(int energyVolume)
        {
            return (energyVolume<freeLimit)?0:base.GetTotalCost(energyVolume-freeLimit);
        }
    }
}
