using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PromosV1.DAO;
using PromosV1.Models;

namespace PromosV1.Controllers
{
    public class MestreController : PadraoController<MestreViewModel>
    {
        public MestreController()
        {
            DAO = new MestreDAO();
            GeraProximoId = true;
        }

        protected override void PreencheDadosParaView(string Operacao, MestreViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
        }

        protected override void ValidaDados(MestreViewModel Loja, string operacao)
        {
            base.ValidaDados(Loja, operacao);
            if (string.IsNullOrEmpty(Loja.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }
    }
}