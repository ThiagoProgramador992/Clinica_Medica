using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.clinicaMedica
{
    public class marcarConsulta
    {
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = ""; 

        public marcarConsulta(String nome, String especialidade)
        {
            // comando sql 
            cmd.CommandText = "insert into consulta (nome, especialidade) values (@nome, @especialidade)";

            // parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@especialidade", especialidade); 
            try
            {
            // conectar com o banco
                cmd.Connection = conexao.conectar();
            // executar comando
                cmd.ExecuteNonQuery();
            // desconectar 
                conexao.desconectar();
                // mostrar imagem de erro ou sucesso
                this.mensagem = "consulta amrcada com sucesso!"; 
            }
            catch (SqlException e)
            {
                this.mensagem = "ocorreu um erro ao se conectar com o banco!"; 
            }

        }
    }
}
