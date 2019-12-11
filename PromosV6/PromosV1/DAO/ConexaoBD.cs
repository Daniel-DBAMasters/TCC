using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PromosV1.DAO
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST;Initial Catalog=db_promos;user id=sa; password=123456";
            //string strCon = "Data Source=LOCALHOST\\SQL_MGV6;Initial Catalog=AULADB;integrated security=true";
            SqlConnection conexao = new SqlConnection(strCon);

            conexao.Open();
            return conexao;
        }
    }
}
