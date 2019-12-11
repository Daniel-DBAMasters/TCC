using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PromosV1.DAO;
using PromosV1.Models;

namespace PromosV1.Controllers
{
    public class LojaController : PadraoController<LojaViewModel>
    {
        public LojaController()
        {
            DAO = new LojaDAO();
            GeraProximoId = true;
        }

        protected override void PreencheDadosParaView(string Operacao, LojaViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            ListarEmpresas();
        }

        protected override void ValidaDados(LojaViewModel Loja, string operacao)
        {
            base.ValidaDados(Loja, operacao);
            if (string.IsNullOrEmpty(Loja.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }

        private void ListarEmpresas()
        {
            MestreDAO mestreDAO = new MestreDAO();
            var mestres = mestreDAO.Listagem();
            List<SelectListItem> listaMestre = new List<SelectListItem>();
            listaMestre.Add(new SelectListItem("Selecione uma empresa", "0"));

            foreach (var mestre in mestres)
            {
                SelectListItem item = new SelectListItem(mestre.NomeEmpresa, mestre.Id.ToString());
                listaMestre.Add(item);
            }
            ViewBag.Empresas = listaMestre;
        }
    }
}