using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DB
{
    //Helper para acesso de dados
    public static class Db
    {
        public string Conexao
        { get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmpresaDB;Integrated Security=True;Pooling=False";
            }
        }
    }
}
