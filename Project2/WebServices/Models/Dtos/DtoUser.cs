using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoUser
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String username { get; set; }
        public String email { get; set; }
        public String position { get; set; }

    }
}