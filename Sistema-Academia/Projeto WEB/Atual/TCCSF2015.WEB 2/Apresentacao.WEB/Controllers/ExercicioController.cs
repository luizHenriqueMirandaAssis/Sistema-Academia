using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjetoTransferencia;
using Negocios;
using System.IO;
using System.Drawing;
using System.Text;
namespace Apresentacao.WEB.Controllers
{
    public class ExercicioController : Controller
    {

        public ActionResult Exercicios(int codigo, string treino)
        {
            ExerciciosTreinamentoNegocio exercicioTreinamentoNegocio = new ExerciciosTreinamentoNegocio();
            ListaExerciciosTreinamento listaExercicioTreinamento = new ListaExerciciosTreinamento();
            listaExercicioTreinamento = exercicioTreinamentoNegocio.TreinamentoPesquisaeListaExercicios(codigo);
            ViewBag.Treino = treino;
            ViewBag.IDAluno = Request.Cookies["IDAluno"].Value;
            Response.Cookies["IDTreinamento"].Value = codigo.ToString();
            return View(listaExercicioTreinamento);
        }

     

        public ActionResult MostrarExercicio(int codigo, string treino)
        {
            ExercicioNegocio exercicioNegocio = new ExercicioNegocio();
            ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(codigo, null);
            ViewBag.ExercicioNome = listaExercicio.Select(c => c.Nome).First();
            ViewBag.IDTreinamento = Request.Cookies["IDTreinamento"].Value;
            ViewBag.Treino = treino;
            ViewBag.Url = "localhost";
         
            return View(listaExercicio.First());
        }



    }
}
