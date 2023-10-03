
namespace SistemaDeEstacionamento.Models
{
    class Veiculo
    {
        public string VehiclePlate { get; set; }

        public Veiculo(string vehiclePlate)
        {
            VehiclePlate = vehiclePlate;
        }

        public override string ToString()
        {
            return VehiclePlate;
        }
    }
}
