using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.WEB.Controllers
{
    public class MedidaCorporalController : Controller
    {       

        public ActionResult Index(int IDAluno)
        {
            MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio();
            ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.ListaMedidaCorporalAlunoWEB(IDAluno);
            
            if(listaMedidaCorporal.Count == 0)
            {
                ViewBag.DataMedida = "Nenhuma medida corporal cadastrara";
                return View(listaMedidaCorporal);
              
            }
            var dataMedida = listaMedidaCorporal.Select(c => c.DataMedida).First();
            ViewBag.DataMedida = dataMedida;
            return View(listaMedidaCorporal);
        }

    }
}
