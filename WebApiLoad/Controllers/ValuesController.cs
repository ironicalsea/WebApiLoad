﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace WebApiLoad.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value7", "value6" };
        }

        [SwaggerOperation("GetString")]
        public IEnumerable<string> Get2(string str)
        {
            return new string[] { str };
        }

        [SwaggerOperation("GetString")]
        public IEnumerable<string> Get3(string str)
        {
            return new string[] { str };
        }

        [SwaggerOperation("GetString")]
        public IEnumerable<string> Get4(string str)
        {
            return new string[] { str };
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
