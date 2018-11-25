using HW6_1.Extend;
using HW6_1.Tarifs;
using System;

namespace HW6_1.Clients
{
    abstract class Client:IComparable
    {
        public ClientType Type { get; protected set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        int energyVolume;
        public int EnergyVolume
        {
            get => energyVolume;
            set
            {
                if (value >= 0)
                {
                    energyVolume = value;
                }
                else
                    throw new Exception("Количество потребленной энергии не может быть меньше нуля");
            }
        }
        protected Tariff tariff;
        protected abstract void SetTariff(Tariff t);
        public Tariff Tariff
        {
            get => tariff;
            set
            {
                SetTariff(value);
            }
        }
        public Client(string name, string addres, Tariff tariff, int energyVolume)
        {
            Name = name;
            Addres = addres;
            Tariff = tariff;
            EnergyVolume = energyVolume;
        }
        public decimal GetEnergyPayment()
        {
            return (Math.Round(tariff.GetTotalCost(energyVolume), 2));
        }

        public void Print(string col1Name, int col1Width, string col2Addres, int col2Width, string col3Type, int col3Width, 
            string col4Volume, int col4Width, string col5Cost, int col5Width)
        {
            Table table = new Table("", new Table.Column(col1Name, col1Width), new Table.Column(col2Addres, col2Width),
    new Table.Column(col3Type, col3Width), new Table.Column(col4Volume, col4Width), new Table.Column(col5Cost, col5Width));
            table.PrintHead(false);
            table.PrintString(Name, Addres, Type.ToString(), EnergyVolume.ToString(), GetEnergyPayment().ToString());
            table.PrintBottom();
        }

        public int CompareTo(object obj)
        {
            Client cl = obj as Client;
            if (cl != null)
                return (-this.EnergyVolume.CompareTo(cl.EnergyVolume));
            return 1;
        }
    }
}
