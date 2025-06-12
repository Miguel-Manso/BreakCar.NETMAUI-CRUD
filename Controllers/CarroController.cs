using BreakCar.Models;
using BreakCar.Services;
using SQLite;

namespace BreakCar.Controllers
{
    public class CarroController
    {
        private DatabaseService databaseService;

        private SQLiteConnection connection;

        public CarroController()
        {
            databaseService = new DatabaseService();

            connection = databaseService.GetConexao();

            connection.CreateTable<Carro>();
        }

        public bool Insert(Carro value)
        {
            return connection.Insert(value) > 0;
        }

        public bool Update(Carro value)
        {
            return connection.Update(value) > 0;
        }
        public bool Delete(Carro value)
        {
            return connection.Delete(value) > 0;
        }

        public List<Carro> GetAll()
        {
            return connection.Table<Carro>().ToList();
        }

        public Carro GetById(int value)
        {
            return connection.Find<Carro>(value);
        }

        public List<Carro>GetByFilters(string placa, DateTime? data, string statusPagamento)
        {
            var query = connection.Table<Carro>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                query = query.Where(c => c.Placa.ToLower().Contains(placa.ToLower()));
            }

            if (data.HasValue)
            {
                var diaInicio = data.Value.Date;
                var diaFim = diaInicio.AddDays(1);
                query = query.Where(c => c.DataHoraEntrada >= diaInicio && c.DataHoraEntrada < diaFim);
            }

            if (!string.IsNullOrEmpty(statusPagamento) && statusPagamento != "Todos")
            {
                bool pago = statusPagamento == "Pago";
                query = query.Where(c => c.Pago == pago);
            }

            return query.ToList();
        }


    }
}
