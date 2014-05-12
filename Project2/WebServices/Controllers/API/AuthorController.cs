using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models.Dtos;

namespace WebServices.Controllers.API
{
    public class AuthorController : ApiController
    {

        [HttpGet]
        public DtoUser byId(Guid token, Guid authorId)
        {
            if (AccountController.isValidWriter(authorId.ToString()))
            {
                return DtoUser.UserForUserId(authorId);
            }

            return null;
        }
    }
}
