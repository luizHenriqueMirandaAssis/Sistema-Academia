using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ListaNoticia todasNoticia = new ListaNoticia();
        private  Noticia noticia = new Noticia();
        public HomeController()
        {
            NoticiaNegocio noticiaNegocio = new NoticiaNegocio();           
            todasNoticia = noticiaNegocio.ConsultarNoticia(null, "%");
            
        }
       

        public ActionResult Index()
        {         
            return View();
        }

        public ActionResult Noticias()
        {
            return View(todasNoticia);
        }

    
        public ActionResult MostrarNoticia(int idNoticia)
        {
            NoticiaNegocio noticiaNegocio = new NoticiaNegocio();
            ListaNoticia listaNoticia = noticiaNegocio.ConsultarNoticia(idNoticia, null);
            noticia = listaNoticia.First();
            
            ViewBag.Titulo = noticia.Titulo;
            return View(noticia);
        }
     

    }
}
