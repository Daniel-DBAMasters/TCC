using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PromosV1.Models;

namespace PromosV1.DAO
{
    public class LojaDAO : PadraoDAO<LojaViewModel>
    {
        LojaViewModel l;
        protected override SqlParameter[] CriaParametros(LojaViewModel model)
        {
            SqlParameter[] parametros =
            {
                    
                    new SqlParameter("cnpj", model.Cnpj),
                    new SqlParameter("nome", model.Nome),
                    new SqlParameter("cidade", model.Cidade),
                    new SqlParameter("estado", model.Estado),
                    new SqlParameter("idEmpresa", model.IdEmpresa),

            };

            return parametros;
        }

        protected override LojaViewModel MontaModel(DataRow registro)
        {
            LojaViewModel l = new LojaViewModel();

            l.Id = Convert.ToInt32(registro["id"]);
            l.Cnpj = registro["cnpj"].ToString();
            l.Nome = registro["nome"].ToString();
            l.Cidade = registro["cidade"].ToString();
            l.Estado = registro["estado"].ToString();
            l.IdEmpresa = Convert.ToInt32(registro["idEmpresa"]);

            return l;
        }
        protected override void SetTabela()
        {
            Tabela = "tb_loja";
        }
    }
}
