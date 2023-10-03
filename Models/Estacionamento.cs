

namespace SistemaDeEstacionamento.Models
{
    class Estacionamento
    {
        public double Price { get; set; }
        public double PricePerHour { get; set; }

        public List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(double price, double pricePerHour)
        {
            Price = price;
            PricePerHour = pricePerHour;
        }


        public void AddVehicle(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void RemoveVehicle(Veiculo veiculo)
        {
            veiculos.Remove(veiculo);
        }

        public void ListVehicles()
        {
            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine("Total de veículos estacionados: " + veiculos.Count);
                Console.WriteLine("------------");
                Console.WriteLine(veiculo);
            }
        }

        public double TotalValue(int hours)
        {
            return PricePerHour * hours + Price;
        }



    }
}
