using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoLoginResponse
    {
        public String accessToken { get; set; }
        public DtoUser user { get; set; }
    }
}