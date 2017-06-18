using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBD.Models
{
    static class  Banco
    {
        public static MySqlConnection GetConexao()
        {

            MySqlConnection Conexao = new MySqlConnection("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
            Conexao.Open();
            return Conexao;


        }
        public static MySqlCommand GetComando(MySqlConnection Conexao)
        {
            MySqlCommand Comando = Conexao.CreateCommand();
            return Comando;


        }
        public static MySqlDataReader GetReader(MySqlCommand Comando)
        {
            MySqlDataReader Reader= Comando.ExecuteReader();
            return Reader;


        }

    }
}
