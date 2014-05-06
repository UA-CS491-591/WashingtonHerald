using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models.Dtos;

namespace WebServices.Controllers
{
    public class AccountController : ApiController
    {
        private const String readerAccessToken = "b7a2ac80-67a7-41bb-a7ff-8e6574b0bdf2";
        private const String writerAccessToken = "b6a5b4f7-3e7f-4f2e-aca3-932f0a2a7f1d";

        [HttpPost]
        public DtoLoginResponse login(DtoLogin dtoLogin)
        {
            if (dtoLogin != null)
            {
                if (!String.IsNullOrEmpty(dtoLogin.password) && !String.IsNullOrEmpty(dtoLogin.username))
                {
                    DtoLoginResponse response = new DtoLoginResponse();
                    response.user = DtoUser.UserForUserName(dtoLogin.username);

                    //Check password
                    if (dtoLogin.username.Equals("zbarnes") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;
                    }
                    else if (dtoLogin.username.Equals("lgoodwin") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;
                    }
                    else if (dtoLogin.username.Equals("jskorsky") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;
                    }
                    else if (dtoLogin.username.Equals("funderwood") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;
                    }
                    else if (dtoLogin.username.Equals("cunderwood") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;
                    }
                    else if (dtoLogin.username.Equals("dstamper") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;
                    }

                    return response;
                }
            }

            return null;
        }

        public static Boolean isValidWriter(string token)
        {
            return token.Equals(writerAccessToken);
        }

        public static Boolean isValidReader(string token)
        {
            return token.Equals(readerAccessToken);
        }
    }
}
