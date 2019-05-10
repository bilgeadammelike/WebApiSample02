using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LessonTwo.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Post([FromBody]Category deger)
        {
            if (deger != null)
            {
                return Ok("oldu bu iş");
            }
            else
            {
                return BadRequest("olmadı malesef");
            }
        }
        //download eder.
        //[NonAction]
        public HttpResponseMessage Get()
        {
            
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");

            response.Content = new StringContent("hello", Encoding.Unicode);

            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };
            //BadRequest("işlem başarısız..");
            return response;
        }
    }
}
