using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models.Dtos;

namespace WebServices.Controllers.API
{
    public class StoryController : ApiController
    {
        StoryModelContainer db = new StoryModelContainer();

        [HttpGet]
        public List<DtoStory> recent(string token)
        {
            if (AccountController.isValidReader(token) || AccountController.isValidWriter(token))
            {
                List<Story> stories = db.Stories.OrderByDescending(s => s.DatePublished).Take(20).ToList();

                if (stories != null)
                {
                    List<DtoStory> dtoStories = new List<DtoStory>();

                    foreach (Story story in stories)
                    {
                        dtoStories.Add(DtoStory.dtoFromStory(story));
                    }

                    return dtoStories;
                }
            }

            return null;
        }

        [HttpGet]
        public List<DtoStory> byCategory(Guid token, string categoryId)
        {
            if (AccountController.isValidReader(token.ToString()) || AccountController.isValidWriter(token.ToString()))
            {
                Category category = db.Categories.Where(c => c.Id.Equals(token)).SingleOrDefault();

                List<Story> stories = category.Stories.OrderByDescending( s => s.DatePublished).ToList();

                if (stories != null)
                {
                    List<DtoStory> dtoStories = new List<DtoStory>();

                    foreach (Story story in stories)
                    {
                        dtoStories.Add(DtoStory.dtoFromStory(story));
                    }

                    return dtoStories;
                }
            }

            return null;
        }

        [HttpGet]
        public List<DtoStory> search(string token, string searchString)
        {
            if (AccountController.isValidReader(token) || AccountController.isValidWriter(token))
            {
                List<Story> stories = db.Stories.Where(s => s.Title.Contains(searchString) || s.Subtitle.Contains(searchString) || s.Body.Contains(searchString)).OrderByDescending(s => s.DatePublished).Take(20).ToList();

                if (stories != null)
                {
                    List<DtoStory> dtoStories = new List<DtoStory>();

                    foreach (Story story in stories)
                    {
                        dtoStories.Add(DtoStory.dtoFromStory(story));
                    }

                    return dtoStories;
                }
            }

            return null;
        }

        [HttpPost]
        public DtoStory add(DtoAddStory dtoAddStory)
        {
            if (AccountController.isValidWriter(dtoAddStory.accessToken))
            {
                Category category = db.Categories.Where(c => c.Id.Equals(dtoAddStory.categoryId)).SingleOrDefault();

                if (category != null)
                {
                    Story story = DtoStory.newStoryFromDto(dtoAddStory.story);

                    if (story != null)
                    {
                        category.Stories.Add(story);
                        db.SaveChanges();

                        return DtoStory.dtoFromStory(story);
                    }
                }
            }

            return null;
        }

        [HttpPut]
        public Boolean edit(DtoEditStory dto){

            if (AccountController.isValidWriter(dto.accessToken))
            {
                Story story = db.Stories.Where(s => s.Id.Equals(dto.story.storyId)).SingleOrDefault();

                if (story != null)
                {
                    story.Title = dto.story.title;
                    story.Subtitle = dto.story.subtitle;
                    story.Body = dto.story.body;
                    story.Lat = dto.story.lat;
                    story.Lng = dto.story.lng;
                    story.DateUpdated = DateTime.UtcNow;

                    db.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        [HttpDelete]
        public Boolean delete(string token, Guid storyId)
        {

            if (AccountController.isValidWriter(token))
            {
                Story story = db.Stories.Where(s => s.Id.Equals(storyId)).SingleOrDefault();

                if (story != null)
                {
                    db.Stories.Remove(story);

                    db.SaveChanges();
                    return true;
                }
            }

            return false;
        }
    }
}
