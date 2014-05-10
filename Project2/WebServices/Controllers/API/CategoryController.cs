using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models.Dtos;

namespace WebServices.Controllers.API
{
    public class CategoryController : ApiController
    {
        StoryModelContainer db = new StoryModelContainer();

        [HttpGet]
        public List<DtoCategory> categories(string token)
        {
            if (AccountController.isValidReader(token) || AccountController.isValidWriter(token))
            {
                List<Category> categories = db.Categories.ToList();

                if (categories != null)
                {
                    List<DtoCategory> dtoCategories = new List<DtoCategory>();
                    foreach (Category category in categories)
                    {
                        dtoCategories.Add(DtoCategory.dtoFromCategory(category));
                    }

                    return dtoCategories;
                }
            }

            return null;
        }
    }
}
