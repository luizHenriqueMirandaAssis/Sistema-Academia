using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjetoTransferencia;
using Negocios;
using System.Web.Security;

namespace Apresentacao.WEB.Controllers
{
    public class AutenticacaoController : Controller
    {
        //
        // GET: /Autenticacao/

        private void WriteCookies()
        {
            var newCookie = new HttpCookie("user");
            newCookie.Value = Session["IDAluno"].ToString();
            newCookie.Expires = DateTime.Now.AddMinutes(30);
            newCookie.Secure = true;
            Response.Cookies.Add(newCookie);
        }

        public ActionResult Login()
        {
            Aluno aluno = new Aluno();
            aluno.Pessoa = new Pessoa();
            return View(aluno);
        }

        [HttpPost]
        public ActionResult Login(Aluno aluno)
        {
            AlunoNegocio alunoNegocio = new AlunoNegocio();
            if (ModelState.IsValid)
            {
                try
                {
                    Aluno alunoLogado = new Aluno();
                    alunoLogado.Pessoa = new Pessoa();
                    alunoLogado = alunoNegocio.LoginAluno(aluno);
                    if (alunoLogado.Pessoa.IDPessoa != 0)
                    {
                        FormsAuthentication.SetAuthCookie(alunoLogado.Pessoa.Nome, false);
                       Response.Cookies["IDAluno"].Value = alunoLogado.Pessoa.IDPessoa.ToString();
                      
                   
                        return RedirectToAction("Index", "Aluno", new { @IDAluno = alunoLogado.Pessoa.IDPessoa });
                    }
                    else
                    {
                        TempData["Erro"] = "Usuário e/ou senha incorretos.";
                    }

                }
                catch (Exception ex)
                {
                    TempData["Erro"] = "Erro ao validar login: " + ex.Message;
                }

            }
            return View(aluno);


        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
