using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LessonTwo.Models;
using LessonTwo.Models.NorthWind;

namespace LessonTwo.Controllers
{
    [RoutePrefix("api/Shipper")]
    public class DenemeController : ApiController
    {
        private LessonTwo.Models.NorthWind.NORTHWNDEntities db = new Models.NorthWind.NORTHWNDEntities();

        //shipper için Get Put Post Delete
        //Controller a api/Shipper diyerek ulaşmalıyız.
        //GetActionı Getshipper olarak çağrıldığında cevap vermeli

        //optinal = Get fonksiyonu Oqeryable calişabilmeli
        //localhost:45678/api/Shipper/GetShipperName

        [Route(Name ="GetShipperName")]
        public List<Shippers> Get()
        {
            List<Shippers> shpper;
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                shpper = db.Shippers.ToList();
            }

            return shpper;
        }

        [Route("")]
        //[HttpPost] //I added this attribute explicitly, and it worked
        public IHttpActionResult Post([FromBody]Shippers s)
        {
            if(s == null)
            {
                return BadRequest();
            }

            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                db.Shippers.Add(s);
                db.SaveChanges();
            }

            return Ok();
        }


        public void PostHede()
        {

        }
    }
}


