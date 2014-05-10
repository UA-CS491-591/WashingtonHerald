using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoAddStory : DtoAccessToken
    {
        public String title { get; set; }
        public String subtitle { get; set; }
        public String body { get; set; }
        public Guid authorId { get; set; }
        public double? lat { get; set; }
        public double? lng { get; set; }
        public Guid categoryId { get; set; }
    }
}