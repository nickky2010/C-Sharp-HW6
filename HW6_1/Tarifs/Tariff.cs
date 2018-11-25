using System;

namespace HW6_1.Tarifs
{
    class Tariff
    {
        public 
        // Одна единица потреблённой энергии стоит 15 коп.
        decimal energyPrice;
        public decimal EnergyPrice
        {
            get
            {
                return energyPrice;
            }
            set
            {
                if (value >= 0)
                {
                    energyPrice = value;
                }
                else
                    throw new Exception("Цена не может быть отрицательной");
            }
        }
        public Tariff(decimal energyPrice=0.15m)
        {
            EnergyPrice = energyPrice;
        }
        // метод расчета стоимости электроэнергии
        public virtual decimal GetTotalCost(int energyVolume)
        {
            return (energyVolume*energyPrice);
        }
    }
}
