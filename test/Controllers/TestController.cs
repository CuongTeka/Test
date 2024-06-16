using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace test.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test")]
        public IHttpActionResult Get()
        {
            return Ok("Hello from TestController!");
        }

        // GET api/test/{id}
        //[HttpGet]
        //[Route("api/test/{id:int}")]
        //public IHttpActionResult Get(int id)
        //{
        //    return Ok($"You requested item {id}");
        //}
    }
}
