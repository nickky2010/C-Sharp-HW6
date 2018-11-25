using System;

namespace HW6_1.Tarifs
{
    class LimitTariff:Tariff
    {
        int limit;
        public int Limit
        {
            get => limit;
            set
            {
                if (value >= 0)
                    limit = value;
                else
                    throw new Exception("Отрицательный лимит");
            }
        }
        double koeff;
        public double Koeff
        {
            get => koeff;
            set
            {
                if (value >= 0)
                    koeff = value;
                else
                    throw new Exception("Отрицательный коэфициент");
            }
        }
        public LimitTariff(decimal energyPrice=0.15m, int limit=150, double koeff=1/3d):base (energyPrice)
        {
            Limit = limit;
            Koeff = koeff;
        }
        public override decimal GetTotalCost(int energyVolume)
        {
            decimal newPrice = EnergyPrice *(decimal) (1 + Koeff);
            decimal temp = base.GetTotalCost(energyVolume);
            return (energyVolume<limit)?temp:temp+(energyVolume-limit)*newPrice;
        }
    }
}
