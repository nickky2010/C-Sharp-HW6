using HW6_1.Extend;

namespace HW6_1.Clients
{
    class ClientCollection
    {
        // метод для вывода массива объектов Client
        public static void Show(string title, string col0Number, int col0Width, string col1Name, int col1Width, string col2Addres, int col2Width,
            string col3Type, int col3Width, string col4Volume, int col4Width, string col5Cost, int col5Width, params Client[] clients)
        {
            Table table = new Table(title, new Table.Column(col0Number, col0Width), new Table.Column(col1Name, col1Width),
                new Table.Column(col2Addres, col2Width), new Table.Column(col3Type, col3Width), new Table.Column(col4Volume, col4Width),
                new Table.Column(col5Cost, col5Width));
            table.PrintHead();
            int number = 0;
            foreach (Client item in clients)
            {
                table.PrintString((++number).ToString(), item.Name, item.Addres, item.Type.ToString(),
                    item.EnergyVolume.ToString(), item.GetEnergyPayment().ToString());
            }
            table.PrintBottom();
        }
        // метод для вычисления общей суммы оплаты всех клиентов за потреблённую энергию.
        public static decimal SumPayment (params Client[] clients)
        {
            decimal sum = 0;
            foreach  (Client client in clients)
            {
                if(client!=null)
                {
                    sum += client.GetEnergyPayment();
                }
            }
            return sum;
        }
        // метод для вычисления общего размера льгот всех клиентов
        public static decimal SumConcession(params Client[] clients)
        {
            decimal sumPayment = 0;
            decimal sumPaymentWithoutConcession = 0;
            foreach (Client client in clients)
            {
                if (client != null)
                {
                    sumPayment += client.GetEnergyPayment();
                    sumPaymentWithoutConcession+= client.EnergyVolume*client.Tariff.EnergyPrice;
                }
            }
            return (sumPaymentWithoutConcession-sumPayment);
        }
    }
}
