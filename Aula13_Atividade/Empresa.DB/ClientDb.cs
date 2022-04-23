using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa.DB
{
    public class ClientDb
    {
        public void Incluir(Cliente cliente)
        {
            string sql = "INSERT INTO Cliente (Id, Nome, Email, Telefone) VALUES (@Id, @Nome, @Email, @Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql,cn);
            cmd.Parameters.AssWithValue("@Id",cliente.Id);
            cmd.Parameters.AssWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AssWithValue("@Email", cliente.Email);
            cmd.Parameters.AssWithValue("@Telefone", cliente.Telefone);
            
            cn.Open();
            int total = cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
