using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.WEB.Controllers
{
    public class TreinamentoController : Controller
    {
        TreinamentoNegocio treinamentoNegocio = new TreinamentoNegocio();
        ListaTreinamento listaTreinamento = new ListaTreinamento();

        public ActionResult Index(int IDAluno)
        {
            var temaSite = "menuAluno";
            listaTreinamento = treinamentoNegocio.PesquisarTreinamentoCodigoNomeAluno(IDAluno, null);
            ViewBag.IDAluno = Request.Cookies["IDAluno"].Value;
            return View(listaTreinamento);
        }

    }
}
