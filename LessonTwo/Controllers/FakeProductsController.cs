﻿using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
    public class FakeProductsController : ApiController
    {

        public List<Product> GetProducts()
        {
            return   new List<Product>
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
}
