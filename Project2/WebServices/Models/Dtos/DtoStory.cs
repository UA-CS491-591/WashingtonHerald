using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models.Dtos
{
    public class DtoStory
    {
        public Guid storyId { get; set; }
        public String title { get; set; }
        public String subtitle { get; set; }
        public String body { get; set; }
        public DateTime datePublished { get; set; }
        public DtoUser author { get; set; }
        public double ? lat { get; set; }
        public double ? lng { get; set; }
        public DtoCategory category { get; set; }

        public static DtoStory dtoFromStory (Story story)
        {

            DtoUser user = DtoUser.UserForUserName(story.author);

            if (user != null)
            {
                DtoStory dto = new DtoStory();
                dto.storyId = story.Id;
                dto.author = DtoUser.UserForUserName(story.author);
                dto.datePublished = story.DatePublished.ToUniversalTime();
                dto.title = story.Title;
                dto.subtitle = story.Subtitle;
                dto.body = story.Body;
                dto.lat = story.Lat;
                dto.lng = story.Lng;

                return dto;
            }

            return null;
        }

        public static Story newStoryFromDto(DtoStory dtoStory)
        {
            //Check for user
            DtoUser user = DtoUser.UserForUserName(dtoStory.author.username);

            if (user != null)
            {
                Story story = new Story();
                story.Id = Guid.NewGuid();
                story.author = user.username;
                story.DatePublished = DateTime.UtcNow;
                story.DateUpdated = DateTime.UtcNow;
                story.Body = dtoStory.body;
                story.Title = dtoStory.title;
                story.Subtitle = dtoStory.subtitle;
                story.Lat = dtoStory.lat;
                story.Lng = dtoStory.lng;

                return story;
            }

            return null;
        }
    }
}