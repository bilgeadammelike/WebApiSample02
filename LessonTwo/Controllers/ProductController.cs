using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
    [RoutePrefix("api/veri")]
    public class ProductController : ApiController
    {
        IEnumerable<Product> GetFakeProducts
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        ProductName="Test1",
                        Price=10,
                        Stock=100
                    },
                    new Product
                    {
                        ProductName = "Test2",
                        Price = 20,
                        Stock=200
                    }
                };
            }
        }
        [Route(Name ="HedeBidi")]
        public HttpResponseMessage Get()
        {
            IEnumerable<Product> products = GetFakeProducts;

          
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }

        
    }
}
