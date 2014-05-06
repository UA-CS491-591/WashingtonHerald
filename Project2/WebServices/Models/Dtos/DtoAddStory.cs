using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoAddStory : DtoAccessToken
    {
        public DtoStory story { get; set; }
        public Guid categoryId { get; set; }
    }
}