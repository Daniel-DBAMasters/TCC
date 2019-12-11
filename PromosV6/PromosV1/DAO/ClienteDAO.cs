using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PromosV1.Models;
using PromosV1.DAO;

namespace PromosV1.DAO
{
    public class ClienteDAO : PadraoDAO<ClienteViewModel>
    {
        protected override SqlParameter[] CriaParametros(ClienteViewModel model)
        {
            SqlParameter[] parametros =
            {
                    
                    new SqlParameter("cpf", model.Cpf),
                    new SqlParameter("nome", model.Nome),
                    new SqlParameter("cidade", model.Cidade),
                    new SqlParameter("estado", model.Estado),
                    new SqlParameter("email", model.Email),
                    new SqlParameter("telefone", model.Telefone),
                    new SqlParameter("senha", model.Senha),

            };

            return parametros;
        }

        protected override ClienteViewModel MontaModel(DataRow registro)
        {
            ClienteViewModel c = new ClienteViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Cpf = registro["cpf"].ToString(),
                Nome = registro["nome"].ToString(),
                Email = registro["email"].ToString(),
                Senha = registro["senha"].ToString(),
                Telefone = registro["telefone"].ToString(),
                Cidade = registro["cidade"].ToString(),
                Estado = registro["estado"].ToString(),

            };
            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "tb_cliente";
        }
    }
}
