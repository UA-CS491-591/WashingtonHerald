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
        public Boolean isWriter { get; set; }


        public static DtoUser UserForUserName(string username)
        {
            DtoUser user = new DtoUser();

            if (username.Equals("zbarnes"))
            {

                //Define user
                user.firstName = "Zoey";
                user.lastName = "Barnes";
                user.email = "zbarnes@washHerald.com";
                user.position = "Staff Writer";
                user.isWriter = true;
                return user;
            }
            else if (username.Equals("lgoodwin"))
            {

                //Define user
                user.firstName = "Lucas";
                user.lastName = "Goodwin";
                user.email = "lgoodwin@washHerald.com";
                user.position = "Political Editor";
                user.isWriter = true;
                return user;
            }
            else if (username.Equals("jskorsky"))
            {

                //Define user
                user.firstName = "Janine";
                user.lastName = "Skorsky";
                user.email = "jskorsky@washHerald.com";
                user.position = "Chief Political Correspondent";
                user.isWriter = true;
                return user;
            }
            else if (username.Equals("funderwood"))
            {

                //Define user
                user.firstName = "Frank";
                user.lastName = "Underwood";
                user.email = "underwood@house.gov";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }
            else if (username.Equals("cunderwood"))
            {

                //Define user
                user.firstName = "Claire";
                user.lastName = "Underwood";
                user.email = "claired@cwi.org";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }
            else if (username.Equals("dstamper"))
            {

                //Define user
                user.firstName = "Doug";
                user.lastName = "Stamper";
                user.email = "dstamper@house.gov";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }

            return null;
        }
    }
}