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

            DtoUser user = DtoUser.UserForUserId(story.authorId);

            if (user != null)
            {
                DtoStory dto = new DtoStory();
                dto.storyId = story.Id;
                dto.author = DtoUser.UserForUserId(story.authorId);
                dto.datePublished = story.DatePublished.ToUniversalTime();
                dto.title = story.Title;
                dto.subtitle = story.Subtitle;
                dto.body = story.Body;
                dto.lat = story.Lat;
                dto.lng = story.Lng;
                dto.category = DtoCategory.dtoFromCategory(story.Category);

                return dto;
            }

            return null;
        }

        public static DtoStory lightDtoFromStory(Story story)
        {

            DtoUser user = DtoUser.UserForUserId(story.authorId);

            if (user != null)
            {
                DtoStory dto = new DtoStory();
                dto.storyId = story.Id;
                dto.author = DtoUser.UserForUserId(story.authorId);
                dto.datePublished = story.DatePublished.ToUniversalTime();
                dto.title = story.Title;
                dto.subtitle = story.Subtitle;
                dto.body = null;
                dto.lat = story.Lat;
                dto.lng = story.Lng;
                dto.category = DtoCategory.dtoFromCategory(story.Category);

                return dto;
            }

            return null;
        }

        public static Story newStoryFromDto(DtoAddStory dtoStory)
        {
            //Check for user
            DtoUser user = DtoUser.UserForUserId(dtoStory.authorId);

            if (user != null)
            {
                Story story = new Story();
                story.Id = Guid.NewGuid();
                story.authorId = user.Id;
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