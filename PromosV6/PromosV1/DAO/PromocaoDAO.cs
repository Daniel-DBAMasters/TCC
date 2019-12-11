using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PromosV1.Models;

namespace PromosV1.DAO
{
    public class PromocaoDAO : PadraoDAO<PromocaoViewModel>
    {
        protected override SqlParameter[] CriaParametros(PromocaoViewModel model)
        {
            SqlParameter[] parametros =
            {
                
                new SqlParameter("nome", model.Nome),
                new SqlParameter("dataInicio", model.DataInicio),
                new SqlParameter("dataFim", model.DataFim),
                new SqlParameter("carimbos", model.Carimbos),
                new SqlParameter("idMestre", model.IdMestre)

            };

            return parametros;
        }

        protected override PromocaoViewModel MontaModel(DataRow registro)
        {
            PromocaoViewModel c = new PromocaoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString(),
                DataInicio = Convert.ToDateTime(registro["dataInicio"]),
                DataFim = Convert.ToDateTime(registro["dataFim"]),
                Carimbos = Convert.ToInt32(registro["carimbos"]),
                IdMestre = Convert.ToInt32(registro["idMestre"])

            };
            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "tb_promocao";
        }
    }
}
