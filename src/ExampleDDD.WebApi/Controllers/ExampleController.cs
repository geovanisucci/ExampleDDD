using ExampleDDD.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleDDD.WebApi.Controllers
{
    public class ExampleController : ApiController
    {
        //Test git flow.

        public List<Pessoa> Get()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa() { Codigo = 1, Nome = "Geovani" });
            pessoas.Add(new Pessoa() { Codigo = 2, Nome = "Ricardo" });
            pessoas.Add(new Pessoa() { Codigo = 3, Nome = "MA" });

            return pessoas;
        }
    }


}
