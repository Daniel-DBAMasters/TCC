using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PromosV1.DAO;
using PromosV1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PromosV1.Controllers
{
    public class PromocaoController : PadraoController<PromocaoViewModel>
    {
        public PromocaoController()
        {
            DAO = new PromocaoDAO();
            GeraProximoId = true;
        }

        protected override void PreencheDadosParaView(string Operacao, PromocaoViewModel model)
        {
            base.PreencheDadosParaView(Operacao, model);
            ListarEmpresas();
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