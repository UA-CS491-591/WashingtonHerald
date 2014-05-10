using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoUser
    {
        public Guid Id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String username { get; set; }
        public String email { get; set; }
        public String position { get; set; }
        public Boolean isWriter { get; set; }


        public static DtoUser UserForUserName(string username)
        {
            DtoUser user = new DtoUser();
            user.username = username;

            if (username.Equals("zbarnes"))
            {

                //Define user
                user.Id = Guid.Parse("0c9ab8b0-3bda-4a88-bbe8-889d5634acb3");
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
                user.Id = Guid.Parse("56cff640-98af-4cfb-a773-177f0f1f717d");
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
                user.Id = Guid.Parse("213a2e01-1886-444a-a077-6664bccffb35");
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
                user.Id = Guid.Parse("f22123e5-34bb-425b-a217-30ac27003c7a");
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
                user.Id = Guid.Parse("ea67dd8d-c44d-4c93-8b57-128e8bd4e458");
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
                user.Id = Guid.Parse("0978c806-bd4c-4687-aa45-772fdd4547c0");
                user.firstName = "Doug";
                user.lastName = "Stamper";
                user.email = "dstamper@house.gov";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }

            return null;
        }

        public static DtoUser UserForUserId(Guid userId)
        {
            DtoUser user = new DtoUser();

            if (userId.Equals(Guid.Parse("0c9ab8b0-3bda-4a88-bbe8-889d5634acb3")))
            {

                //Define user
                user.Id = Guid.Parse("0c9ab8b0-3bda-4a88-bbe8-889d5634acb3");
                user.firstName = "Zoey";
                user.lastName = "Barnes";
                user.username = "zbarnes";
                user.email = "zbarnes@washHerald.com";
                user.position = "Staff Writer";
                user.isWriter = true;
                return user;
            }
            else if (userId.Equals(Guid.Parse("56cff640-98af-4cfb-a773-177f0f1f717d")))
            {

                //Define user
                user.Id = Guid.Parse("56cff640-98af-4cfb-a773-177f0f1f717d");
                user.firstName = "Lucas";
                user.lastName = "Goodwin";
                user.username = "lgoodwin";
                user.email = "lgoodwin@washHerald.com";
                user.position = "Political Editor";
                user.isWriter = true;
                return user;
            }
            else if (userId.Equals(Guid.Parse("213a2e01-1886-444a-a077-6664bccffb35")))
            {

                //Define user
                user.Id = Guid.Parse("213a2e01-1886-444a-a077-6664bccffb35");
                user.firstName = "Janine";
                user.lastName = "Skorsky";
                user.username = "jskorsky";
                user.email = "jskorsky@washHerald.com";
                user.position = "Chief Political Correspondent";
                user.isWriter = true;
                return user;
            }
            else if (userId.Equals(Guid.Parse("f22123e5-34bb-425b-a217-30ac27003c7a")))
            {

                //Define user
                user.Id = Guid.Parse("f22123e5-34bb-425b-a217-30ac27003c7a");
                user.firstName = "Frank";
                user.lastName = "Underwood";
                user.username = "funderwood";
                user.email = "underwood@house.gov";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }
            else if (userId.Equals(Guid.Parse("ea67dd8d-c44d-4c93-8b57-128e8bd4e458")))
            {

                //Define user
                user.Id = Guid.Parse("ea67dd8d-c44d-4c93-8b57-128e8bd4e458");
                user.firstName = "Claire";
                user.lastName = "Underwood";
                user.username = "cunderwood";
                user.email = "claired@cwi.org";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }
            else if (userId.Equals(Guid.Parse("0978c806-bd4c-4687-aa45-772fdd4547c0")))
            {

                //Define user
                user.Id = Guid.Parse("0978c806-bd4c-4687-aa45-772fdd4547c0");
                user.firstName = "Doug";
                user.lastName = "Stamper";
                user.username = "dstamper";
                user.email = "dstamper@house.gov";
                user.position = "Subscriber";
                user.isWriter = false;
                return user;
            }

            return null;
        }
    }
}