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
    public class MunicipiosController : ApiController
    {
        private readonly IMunicipiosApplication _municipiosApplication;

        public MunicipiosController(IMunicipiosApplication municipiosApplication)
        {
            _municipiosApplication = municipiosApplication;
        }

        // GET: api/Municipios
        [HttpGet]
        public IEnumerable<Municipios> Get()
        {
            return _municipiosApplication.GetAll();
        }

        // GET: api/Municipios/5
        [HttpGet]
        public Municipios Get(int id)
        {
            return _municipiosApplication.Get(id);
        }

        // POST: api/Municipios
        [HttpPost]
        public void Post([FromBody]Municipios value)
        {
            _municipiosApplication.Create(value);
        }

        // PUT: api/Municipios/5
        [HttpPut]
        public void Put(int id, [FromBody]Municipios value)
        {
            value.Id = id;
            _municipiosApplication.Update(value);
        }

        // DELETE: api/Municipios/5
        [HttpDelete]
        public void Delete(int id)
        {
            _municipiosApplication.Delete(id);
        }
    }
}
