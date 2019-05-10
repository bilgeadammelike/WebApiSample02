using LessonTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonTwo.Controllers
{
    public class CategoryController : ApiController
    {
        public Category RepositoryByID(int id)
        {

            List<Category> fakeCategories = new List<Category>
            {
                new Category { CategoryName="Test2Category", Description="Desc2", ID=2 },
                new Category { CategoryName = "TestCategory", Description = "Desc", ID=1 }

            };

            return fakeCategories.Find(item => item.ID == id);
        }


        public IHttpActionResult Get(int id)
        {
            Category category = RepositoryByID(id);

            if (category == null)
            {
                return NotFound(); // Returns a NotFoundResult
            }
            return Ok(category);  // Returns an OkNegotiatedContentResult
        }

    }
}
