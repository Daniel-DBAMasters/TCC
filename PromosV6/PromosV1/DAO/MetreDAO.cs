using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PromosV1.Models;

namespace PromosV1.DAO
{
    public class MestreDAO : PadraoDAO<MestreViewModel>
    {
        protected override SqlParameter[] CriaParametros(MestreViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            
            parametros[1] = new SqlParameter("nome", model.Nome);
            parametros[2] = new SqlParameter("nomeEmpresa", model.NomeEmpresa);
            parametros[3] = new SqlParameter("senha", model.Senha);

            return parametros;
        }

        protected override MestreViewModel MontaModel(DataRow registro)
        {
            MestreViewModel m = new MestreViewModel();
            m.Id = Convert.ToInt32(registro["id"]);
            m.Nome = registro["nome"].ToString();
            m.NomeEmpresa = registro["nomeEmpresa"].ToString();
            m.Senha = registro["senha"].ToString();
            return m;
        }

        protected override void SetTabela()
        {
            Tabela = "tb_mestre";
        }

        /*public void Inserir(MestreViewModel mestre)
        {
            string sql =
            "insert into tb_mestre(id, nomeEmpresa, nome, senha)" +
            "values ( @id, @nomeEmpresa, @nome, @senha)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(mestre));
        }

        public void Alterar(MestreViewModel mestre)
        {
            string sql =
            "update tb_mestre set nomeEmpresa = @nomeEmpresa, nome=@nome, senha=@senha where id =@id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(mestre));
        }*/

        public void Excluir(int id)
        {
            string sql = "delete tb_mestre where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public void Inserir(MestreViewModel mestre)
        {
            HelperDAO.ExecutaProc("spInsert_tb_mestre", CriaParametros(mestre));
        }

        //############################## ALTERAR ESTE TRECHO PARA A SP DA APOSTILA ###################################

        public void Alterar(MestreViewModel mestre)
        {
            HelperDAO.ExecutaProc("spAlteraAluno", CriaParametros(mestre));
        }

        //############################## ALTERAR ESTE TRECHO PARA A SP DA APOSTILA ###################################
    }
}
