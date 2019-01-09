using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleDDD.WebApi.Controllers
{
    public class EstadosController : ApiController
    {
        private readonly IEstadosApplication _estadosApplication;

        public EstadosController(IEstadosApplication estadosApplication)
        {
            _estadosApplication = estadosApplication;
        }

        // GET: api/Estados
        public IEnumerable<Estados> Get()
        {
            return _estadosApplication.GetAll();
        }

        // GET: api/Estados/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Estados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Estados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Estados/5
        public void Delete(int id)
        {
        }
    }
}
