using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Filters;
using PromosV1.Models;
using PromosV1.DAO;

namespace PromosV1.Controllers
{
    public class ClienteController : PadraoController<ClienteViewModel>
    {
        public ClienteController()
        {
            DAO = new ClienteDAO();
            GeraProximoId = true;
        }

        protected override void PreencheDadosParaView(string Operacao, ClienteViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
        } 

        protected override void ValidaDados(ClienteViewModel Cliente, string operacao)
        {
            base.ValidaDados(Cliente, operacao);
            if (string.IsNullOrEmpty(Cliente.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }
    }
}