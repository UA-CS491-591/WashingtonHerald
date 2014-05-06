using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoCategory
    {
        public Guid categoryId { get; set; }
        public String name { get; set; }
        public String description { get; set; }

        public static DtoCategory dtoFromCategory(Category category){
            DtoCategory dtoCategory = new DtoCategory();

            dtoCategory.categoryId = category.Id;
            dtoCategory.name = category.Name;
            dtoCategory.description = category.Description;

            return dtoCategory;
        }
    }
}