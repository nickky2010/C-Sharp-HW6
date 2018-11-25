using System;

namespace HW6_1.Tarifs
{
    class PreferentialTariffOne :Tariff
    {
        double koeff;
        public double Koeff
        {
            get => koeff;
            set
            {
                if(value>=0 && value < 1)
                {
                    koeff = value;
                }
                else
                {
                    throw new Exception("Неправильный коэффициент");
                }
            }
        }
        public PreferentialTariffOne (decimal energyPrice = 0.15m, double koeff=2/3d):base(energyPrice)
        {
            Koeff = koeff;
        }
        public override decimal GetTotalCost(int energyVolume)
        {
            return (energyVolume*EnergyPrice*(decimal)Koeff);
        }
    }
}
