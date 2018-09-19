using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExampleDDD.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /*Configurações de formato de retorno da API*/
            //Limpar todos os formatos existentes
            GlobalConfiguration.Configuration.Formatters.Clear();

            //Adicionando o Json
            GlobalConfiguration.Configuration.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());

            //Identando o Json
            config.Formatters.JsonFormatter.Indent = true;


        }
    }
}
