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
        public String imageUrl { get; set; }

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
                user.imageUrl = "https://pbs.twimg.com/profile_images/3242188460/3df65e6ab14df234bbe6bfb19da6c7ec.png";
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
                user.imageUrl = "http://img2.wikia.nocookie.net/__cb20130209211723/house-of-cards/images/b/ba/Sk%C3%A6rmbillede_2013-02-09_kl._22.16.56.png";
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
                user.imageUrl = "http://livinginthehouseofcards.files.wordpress.com/2013/03/cz027.jpg";
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
                user.imageUrl = "http://img2.wikia.nocookie.net/__cb20140227094826/house-of-cards/images/d/df/Frank_Underwood_3.jpg";
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
                user.imageUrl = "http://www.lifesitenews.com/images/sized/images/news/ClaireUnderwoodHouseOfCards-250px-240x224.jpg";
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
                user.imageUrl = "https://www.google.com/search?q=doug+stamper&es_sm=93&tbm=isch&imgil=cmk48xq4TA8dLM%253A%253Bhttps%253A%252F%252Fencrypted-tbn0.gstatic.com%252Fimages%253Fq%253Dtbn%253AANd9GcQ2n9trqQrNSW_tpTz0iPt6EEP7vOEwRDd5rVXyxPkoxS2I4dnGYA%253B800%253B440%253BEZIG-yos8rzO-M%253Bhttp%25253A%25252F%25252Fwww.youthconnectmag.com%25252F2014%25252F02%25252F24%25252Fhouse-of-cards-in-india%25252F&source=iu&usg=__w0Wqojp5BDUKF7cl2-JehtjrBv4%3D&sa=X&ei=_f1wU9qNIYqksQT-gIGYDg&ved=0CEAQ9QEwBQ#facrc=_&imgdii=_&imgrc=oG95yeVCfF9BuM%253A%3B-FwB6EeTCti1_M%3Bhttps%253A%252F%252Fpbs.twimg.com%252Fprofile_images%252F3204682365%252F3c8169391816121ce9e06eccf9fc61e0.jpeg%3Bhttps%253A%252F%252Ftwitter.com%252FTheStamperAct%3B240%3B240";
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
                user.imageUrl = "https://pbs.twimg.com/profile_images/3242188460/3df65e6ab14df234bbe6bfb19da6c7ec.png";
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
                user.imageUrl = "http://img2.wikia.nocookie.net/__cb20130209211723/house-of-cards/images/b/ba/Sk%C3%A6rmbillede_2013-02-09_kl._22.16.56.png";
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
                user.imageUrl = "http://livinginthehouseofcards.files.wordpress.com/2013/03/cz027.jpg";
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
                user.imageUrl = "http://img2.wikia.nocookie.net/__cb20140227094826/house-of-cards/images/d/df/Frank_Underwood_3.jpg";
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
                user.imageUrl = "http://www.lifesitenews.com/images/sized/images/news/ClaireUnderwoodHouseOfCards-250px-240x224.jpg";
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
                user.imageUrl = "https://www.google.com/search?q=doug+stamper&es_sm=93&tbm=isch&imgil=cmk48xq4TA8dLM%253A%253Bhttps%253A%252F%252Fencrypted-tbn0.gstatic.com%252Fimages%253Fq%253Dtbn%253AANd9GcQ2n9trqQrNSW_tpTz0iPt6EEP7vOEwRDd5rVXyxPkoxS2I4dnGYA%253B800%253B440%253BEZIG-yos8rzO-M%253Bhttp%25253A%25252F%25252Fwww.youthconnectmag.com%25252F2014%25252F02%25252F24%25252Fhouse-of-cards-in-india%25252F&source=iu&usg=__w0Wqojp5BDUKF7cl2-JehtjrBv4%3D&sa=X&ei=_f1wU9qNIYqksQT-gIGYDg&ved=0CEAQ9QEwBQ#facrc=_&imgdii=_&imgrc=oG95yeVCfF9BuM%253A%3B-FwB6EeTCti1_M%3Bhttps%253A%252F%252Fpbs.twimg.com%252Fprofile_images%252F3204682365%252F3c8169391816121ce9e06eccf9fc61e0.jpeg%3Bhttps%253A%252F%252Ftwitter.com%252FTheStamperAct%3B240%3B240";
                return user;
            }

            return null;
        }
    }
}