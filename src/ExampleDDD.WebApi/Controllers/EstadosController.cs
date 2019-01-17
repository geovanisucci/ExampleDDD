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
        [HttpGet] //Cabeçalho de uma operação GET (operação que retorna informações/conteúdo).
        public IEnumerable<Estados> Get() //Endpoint (ponto de integração). Um método exposto na Web (via WebAPI).
        {
            return _estadosApplication.GetAll(); //XML ou Json.
        }

        // GET: api/Estados/5
        [HttpGet]
        public Estados Get(int id)
        {
            return _estadosApplication.Get(id);
        }

        // POST: api/Estados
        [HttpPost] //Cabeçalho de uma operação POST (operação que inclui um registro).
        public void Post([FromBody]Estados value) //receber o parametro com Json.
        {
            _estadosApplication.Create(value);
        }

        // PUT: api/Estados/5
        [HttpPut] //Cabeçalho de uma operação PUT (operação que atualiza um registro).
        public void Put(int id, [FromBody]Estados value) //Receber um parâmetro de rota id e um parâmetro com Json.
        {
            value.Id = id;
            _estadosApplication.Update(value);
        }

        // DELETE: api/Estados/5
        [HttpDelete] //Cabeçalho de uma operação DELETE (operação que remove um registro)
        public void Delete(int id) //Receber um parâmetro de rota id
        {
            _estadosApplication.Delete(id);
        }
    }
}
