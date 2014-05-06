using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoStory
    {
        public String title { get; set; }
        public String stubtitle { get; set; }
        public String story { get; set; }
        public DateTime datePublished { get; set; }
        public DtoUser author { get; set; }
    }
}