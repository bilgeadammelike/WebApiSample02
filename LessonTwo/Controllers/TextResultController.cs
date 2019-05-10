using LessonTwo.ResultTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
   
    public class TextResultController : ApiController
    {
        //string basar.
        public IHttpActionResult Get()
        {
           // return Ok();
           return new TextResult("hello", Request);
        }
    }
}
