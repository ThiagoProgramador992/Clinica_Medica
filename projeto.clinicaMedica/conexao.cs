using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.clinicaMedica
{
    public class conexao
    {
        SqlConnection connection = new SqlConnection(); 
        
        // construtor
        public conexao()
        {
            connection.ConnectionString = "Data Source=DESKTOP-BITKGT3\\SQLEXPRESS;Initial Catalog=projeto_clinica_medica;Integrated Security=True"; 
        }
        // conectar banco de dados 
        public SqlConnection conectar()
        {
           if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open(); 
            }
            return connection; 
        }
        //desconectar banco de dados
        public void desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
