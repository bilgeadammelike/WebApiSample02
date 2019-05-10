using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
    [RoutePrefix("api/Shipper")]
    public class DenemeController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();

        //Shipper için Get Put Post Delete
        //Controller a api/Shipper diyerek ulaşmalıyız.
        //Get actionı GetShipperName olarak çağırıldığında cevap vermeli. 
        //optinal = Get fonksiyonu Oqueryable çalışabilmeli.

// localhost:45632/api/Shipper/GetShipperName

        [Route(Name = "GetShipperName")]
        public List<Shippers> Get()
        {
            return null;
        }

        public IHttpActionResult Post([FromBody]Shippers s)
        {

            return Ok();
        }

    }
}
