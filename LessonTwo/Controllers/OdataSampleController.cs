using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
    [Queryable]
    public class OdataSampleController : ApiController
    {
        public IQueryable<TestModel> Get()
        {
            List<TestModel> model = new List<TestModel>
            {
                new TestModel{
                    Name="Test1",
                    Description="TestDescription1",
                    IsActive=true,
                    MinValue=10,
                    MaxValue=100
                },
                new TestModel{
                    Name="Test2",
                    Description="TestDescription2",
                    IsActive=true,
                    MinValue=20,
                    MaxValue=50
                },
                 new TestModel{
                    Name="Test3",
                    Description="TestDescription3",
                    IsActive=false,
                    MinValue=25,
                    MaxValue=50
                },
                 new TestModel{
                    Name="Test4",
                    Description="TestDescription4",
                    IsActive=true,
                    MinValue=30,
                    MaxValue=100
                },
                 new TestModel{
                    Name="Test5",
                    Description="TestDescription5",
                    IsActive=true,
                    MinValue=80,
                    MaxValue=120
                },

            };
            return model.AsQueryable();
        }
    }
}
