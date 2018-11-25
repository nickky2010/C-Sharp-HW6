using System;
using HW6_1.Tarifs;

namespace HW6_1.Clients
{
    class ClientPreferentialTwo : Client
    {
        public ClientPreferentialTwo(string name, string addres, Tariff tariff, int energyVolume) : base(name, addres, tariff, energyVolume)
        {
            Type = ClientType.PreferentialTwo;
        }
        protected override void SetTariff(Tariff t)
        {
            Type typeThis = GetType();
            Type typeTariff = t.GetType();
            if (typeTariff.Name == TariffType.PreferentialTariffTwo.ToString())
                tariff = t;
            else
                throw new Exception("Клиенту " + Name + " с типом клиента " + typeThis.Name + " невозможно установить тариф " + typeTariff.Name +
                    ".\nТариф должен быть " + TariffType.PreferentialTariffTwo.ToString());
        }
    }
}
