using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesFront.Models
{
    public class DataBase
    {
        public static SQLiteConnection Conexao;
        
        public static void CreateDataBase(string dbPath)
        {
            SQLiteConnectionString connection = new SQLiteConnectionString(dbPath);

            Conexao = new SQLiteConnection(connection);
        }

        public void Inserir<T>(T Models)
        {
            Conexao.Insert(Models);
        }

    }
}
