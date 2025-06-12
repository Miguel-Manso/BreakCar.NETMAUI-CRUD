using SQLite;

namespace BreakCar.Models
{
    public class Carro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string NomeProprietario { get; set; }
        public string Tipo { get; set; }
        public string Imagem { get; set; }
        public DateTime DataHoraEntrada { get; set; }

        public DateTime? DataHoraSaida { get; set; }
        public bool Pago { get; set; }

    }

}
