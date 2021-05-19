using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Conexao
    {
        string conec = @"Data Source=LAPTOP-9D4CV1D9;Initial Catalog=Cad;Integrated Security=True;";
        public SqlConnection conSql = null;
        public void AbrirCon()
        {
            try
            {
                conSql = new SqlConnection(conec);
                conSql.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void FecharCon()
        {
            try
            {
                conSql = new SqlConnection(conec);
                conSql.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
