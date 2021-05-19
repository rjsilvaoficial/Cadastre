using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class metodosDal
    {
        Conexao con = new Conexao(); //classe que conecta o app ao db
        string sql; // query que atuará no db
        SqlCommand cmd; //objeto que aciona o método que imputa os parametros na query

        /*     Por que não usei métodos estáticos aqui?

         Conforme o(SRP) uma classe deve ter somente uma
         responsabilidade, um método estático viola este princípio
         pois tende a ter uma responsabilidade que não é a mesma da
         classe à qual está vinculado.

                                fonte: http://www.macoratti.net
        */

        public void CadastrarDb(long cpf, string nome, long telefone)
        {
            con.AbrirCon();
            sql = "INSERT INTO PESSOA (CPF,NOME) VALUES (@cpf,@nome)" +
                "INSERT INTO TELEFONE (ID_FONE,TELEFONE) VALUES (@id_fone,@telefone)";
            cmd = new SqlCommand(sql, con.conSql); //query, o con do menu inicial e o con em Conexao
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@id_fone", cpf);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.ExecuteNonQuery();
            con.FecharCon();
        }

        public void ConsultarDb(long cpf, out mdlContato _objBusca)
        {
            mdlContato _mdlContato = new mdlContato();
            con.AbrirCon();
            sql = "SELECT * FROM PESSOA AS P JOIN TELEFONE AS T " +
                "ON P.CPF = T.ID_FONE  WHERE CPF = @cpf";
            cmd = new SqlCommand(sql, con.conSql); //query, o con do menu inicial e o con em Conexao           
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader leitorDB = cmd.ExecuteReader();
            if (leitorDB.Read())
            {
                _mdlContato.nome = leitorDB[1].ToString();
                _mdlContato.telefone = Convert.ToInt64(leitorDB[3]);
            }
            con.FecharCon();
            _objBusca = _mdlContato;
        }

        public void AtualizarDb(long cpf, string nome,long telefone)
        {
            con.AbrirCon();
            sql = "UPDATE PESSOA SET PESSOA.NOME = @nome WHERE CPF = @cpf;  " +
                "UPDATE TELEFONE SET TELEFONE = @telefone WHERE ID_FONE = @cpf; ";
            cmd = new SqlCommand(sql, con.conSql); //query, o con do menu inicial e o con em Conexao
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.ExecuteNonQuery();
            con.FecharCon();


        }

        public void DeletarDb(long cpf)
        {
            con.AbrirCon();
            sql = "DELETE FROM TELEFONE WHERE ID_FONE = @cpf;" +
                "DELETE FROM PESSOA WHERE CPF = @cpf";
            cmd = new SqlCommand(sql, con.conSql); //query, o con do menu inicial e o con em Conexao
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@id_fone", cpf);
            cmd.ExecuteNonQuery();
            con.FecharCon();


        }

    }
}
