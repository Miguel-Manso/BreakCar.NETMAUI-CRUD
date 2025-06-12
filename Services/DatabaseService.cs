using SQLite;
using PCLExt.FileStorage.Folders;

namespace BreakCar.Services
{
    public class DatabaseService
    {
        public SQLiteConnection GetConexao()
        {
            var pasta = new LocalRootFolder();

            var arquivo = pasta.CreateFile("breakcar", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            
            return new SQLiteConnection(arquivo.Path);
        }
    }
}
