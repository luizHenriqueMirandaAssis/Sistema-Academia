using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Apresentacao.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new {controller = "Home", action="Noticias"}
                
                );

            routes.MapRoute(
                name: "Treinamentos Físicos",
                url: "treinamentos/{IDAluno}",
                defaults:new {controller = "Treinamento", action="Index"}                             
                );

            routes.MapRoute(
                name: "Todos os Exercícios",
                url: "exercicios/{codigo}/{treino}",
                defaults: new {controller="Exercicio", action="Exercicios" }
                );

            routes.MapRoute(
                name: "Exercicio Especificado",
                url: "exercicio/{codigo}",
                defaults: new {controller ="Exercicio", action="MostrarExercicio" }        
                );
            routes.MapRoute(
                name: "Login do Aluno",
                url: "login/",
                defaults: new {controller="Autenticacao", action="Login" }
                
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}