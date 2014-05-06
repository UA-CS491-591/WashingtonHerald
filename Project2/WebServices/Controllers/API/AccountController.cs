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
        private static const String readerAccessToken = "b7a2ac80-67a7-41bb-a7ff-8e6574b0bdf2";
        private static const String writerAccessToken = "b6a5b4f7-3e7f-4f2e-aca3-932f0a2a7f1d";

        [HttpGet]
        public DtoLoginResponse login(DtoLogin dtoLogin)
        {
            if (dtoLogin != null)
            {
                if (!String.IsNullOrEmpty(dtoLogin.password) && !String.IsNullOrEmpty(dtoLogin.username))
                {
                    DtoLoginResponse response = new DtoLoginResponse();
                    DtoUser user = new DtoUser();
                    user.username = dtoLogin.username;

                    if (dtoLogin.username.Equals("zbarnes") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;

                        //Define user
                        user.firstName = "Zoey";
                        user.lastName = "Barnes";
                        user.email = "zbarnes@washHerald.com";
                        user.position = "Staff Writer";
                    }
                    else if (dtoLogin.username.Equals("lgoodwin") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;

                        //Define user
                        user.firstName = "Lucas";
                        user.lastName = "Goodwin";
                        user.email = "lgoodwin@washHerald.com";
                        user.position = "Political Editor";
                    }
                    else if (dtoLogin.username.Equals("lgoodwin") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = writerAccessToken;

                        //Define user
                        user.firstName = "Janine";
                        user.lastName = "Skorsky";
                        user.email = "jskorsky@washHerald.com";
                        user.position = "Chief Political Correspondent";
                    }
                    else if (dtoLogin.username.Equals("funderwood") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;

                        //Define user
                        user.firstName = "Frank";
                        user.lastName = "Underwood";
                        user.email = "underwood@house.gov";
                        user.position = "Subscriber";
                    }
                    else if (dtoLogin.username.Equals("funderwood") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;

                        //Define user
                        user.firstName = "Claire";
                        user.lastName = "Underwood";
                        user.email = "claired@cwi.org";
                        user.position = "Subscriber";
                    }
                    else if (dtoLogin.username.Equals("dstamper") && dtoLogin.password.Equals("password"))
                    {
                        response.accessToken = readerAccessToken;

                        //Define user
                        user.firstName = "Doug";
                        user.lastName = "Stamper";
                        user.email = "dstamper@house.gov";
                        user.position = "Subscriber";
                    }

                    response.user = user;

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
