using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apresentacao.WEB.Controllers
{
     [Authorize]
    public class AlunoController : Controller
    {
        //
        // GET: /Aluno/

         

        public ActionResult Index()
        {

            string idAluno = Request.Cookies["IDAluno"].Value;
            ViewBag.IDAluno = idAluno;
            return View();
        }

    }
}
