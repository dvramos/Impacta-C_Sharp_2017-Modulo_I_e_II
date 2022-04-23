using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void conectarButton_Click(object sender, EventArgs e)
        {
            // SQL Server
            // SqlConnection
            //      ConnectionString
            //      Open()
            //      Close()

            // SqlCommand
            //      Connection
            //      CommandText
            //      ExecuteReader()
            //      ExecuteNonQuery()
            //      ExecuteScalar()

            // SqlDataReader
            //      Read()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";
            cn.Open();
            Mensagem("Conexão Aberta!");
            cn.Close();
            Mensagem("Conexão Fechada!");
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome FROM Cliente";

            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }
            reader.Close();
            cn.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id,Nome,Email,Telefone) VALUES (@Id,@Nome,@Email,@Telefone)";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim Exemplo da Silva");
            cmd.Parameters.AddWithValue("@Email", "joaquim.exemplo@email.com");
            cmd.Parameters.AddWithValue("@Telefone", "5555-4321");
            cn.Open();
            Mensagem("Conexão Aberta!");

            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro incluido!");

            cn.Close();
            Mensagem("Conexão Fechada!");
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome = @Nome WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            cmd.Parameters.AddWithValue("@Nome", "Joaquim Alterado da Silva");
            
            cn.Open();
            Mensagem("Conexão Aberta!");

            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro alterado com sucesso!");

            cn.Close();
            Mensagem("Conexão Fechada!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=EmpresaDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 25);
            
            cn.Open();
            Mensagem("Conexão Aberta!");

            int total = cmd.ExecuteNonQuery();
            Mensagem("Registro excluido com sucesso!");

            cn.Close();
            Mensagem("Conexão Fechada!");
        }
    }
}
