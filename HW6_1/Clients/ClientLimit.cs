using System;
using HW6_1.Tarifs;

namespace HW6_1.Clients
{
    class ClientLimit : Client
    {
        public ClientLimit(string name, string addres, Tariff tariff, int energyVolume) : base(name, addres, tariff, energyVolume)
        {
            Type = ClientType.Limit;
        }
        protected override void SetTariff(Tariff t)
        {
            Type typeThis = GetType();
            Type typeTariff = t.GetType();
            if (typeTariff.Name == TariffType.LimitTariff.ToString())
                tariff = t;
            else
                throw new Exception("Клиенту " + Name + " с типом клиента " + typeThis.Name + " невозможно установить тариф " + typeTariff.Name +
                    ".\nТариф должен быть " + TariffType.LimitTariff.ToString());
        }
    }
}
