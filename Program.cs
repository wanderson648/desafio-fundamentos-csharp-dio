using SistemaDeEstacionamento.Models;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o preço inicial:");
        double initialPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Agora digite o preço por hora:");
        double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        int op = 0;
        Console.Clear();
        Estacionamento estacionamento = new Estacionamento(initialPrice, pricePerHour);

        do
        {
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Registrar saída e pagar o estacionamento");
            Console.WriteLine("3 - Listar veículos estacionados");
            Console.WriteLine("4 - Encerrar");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Informe a placa do veículo");
                string vehiclePlate = Console.ReadLine();

                estacionamento.AddVehicle(new Veiculo(vehiclePlate));
            }
            else if (op == 2)
            {
                Console.WriteLine("Informe a placa para registrar saída:");
                string vehiclePlate = Console.ReadLine();
                Console.WriteLine("Informe o total de horas no estacionamento");
                int totalHour = int.Parse(Console.ReadLine());

                Veiculo veiculo = estacionamento.veiculos.Find(v => v.VehiclePlate == vehiclePlate);
                estacionamento.RemoveVehicle(veiculo);

                DateTime dateHour = DateTime.Now;
                double totalPrice = estacionamento.TotalValue(totalHour);

                Console.WriteLine($"Placa do veículo: {vehiclePlate}\n" +
                    $"Saida: {dateHour.ToString("dd/MM/yyyy HH:mm")}\n" +
                    $"Preço total do estacionamento: R$ {totalPrice.ToString("f2", CultureInfo.InvariantCulture)}");
            }
            else if (op == 3)
            {
                estacionamento.ListVehicles();

            }

            Console.WriteLine("Pressione uma tecla para continuar");
            string anyKey = Console.ReadLine();
            Console.Clear();


        } while (op != 4);
        Console.WriteLine("O programa se encerrou");

    }
}