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
        public DtoStory byId(Guid token, Guid storyId)
        {
            if (AccountController.isValidReader(token.ToString()) || AccountController.isValidWriter(token.ToString()))
            {
                //Fetch story
                Story story = db.Stories.Where(s => s.Id.Equals(storyId)).SingleOrDefault();

                if (story != null)
                {
                    return DtoStory.dtoFromStory(story);
                }
            }

            return null;
        }

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
                        dtoStories.Add(DtoStory.lightDtoFromStory(story));
                    }

                    return dtoStories;
                }
            }

            return null;
        }

        [HttpGet]
        public List<DtoStory> byCategory(Guid token, Guid categoryId)
        {
            if (AccountController.isValidReader(token.ToString()) || AccountController.isValidWriter(token.ToString()))
            {
                Category category = db.Categories.Where(c => c.Id == categoryId).SingleOrDefault();

                if (category != null)
                {
                    List<Story> stories = category.Stories.OrderByDescending(s => s.DatePublished).ToList();

                    if (stories != null)
                    {

                        List<DtoStory> dtoStories = new List<DtoStory>();

                        foreach (Story story in stories)
                        {
                            dtoStories.Add(DtoStory.lightDtoFromStory(story));
                        }

                        return dtoStories;
                    }
                    else
                    {
                        return new List<DtoStory>();
                    }
                }
                
            }

            return null;
        }

        [HttpGet]
        public List<DtoStory> byAuthor(Guid token, Guid authorId)
        {
            if (AccountController.isValidReader(token.ToString()) || AccountController.isValidWriter(token.ToString()))
            {

                List<Story> stories = db.Stories.Where(s => s.authorId.Equals(authorId)).OrderByDescending(s => s.DatePublished).ToList();

                if (stories != null)
                {
                    List<DtoStory> dtoStories = new List<DtoStory>();

                    foreach (Story story in stories)
                    {
                        dtoStories.Add(DtoStory.lightDtoFromStory(story));
                    }

                    return dtoStories;
                }
            }

            return null;
        }

        [HttpGet]
        public List<DtoStory> search(string token, string searchString, Guid ? authorId = null)
        {
            if (AccountController.isValidReader(token) || AccountController.isValidWriter(token))
            {
                List<Story> stories = db.Stories.Where(s => s.Title.Contains(searchString)).OrderByDescending(s => s.DatePublished).Take(20).ToList();

                if (stories != null)
                {
                    DtoUser author = null;
                    if (authorId.HasValue)
                    {
                        author = DtoUser.UserForUserId(authorId.Value);
                    }
                    

                    List<DtoStory> dtoStories = new List<DtoStory>();

                    foreach (Story story in stories)
                    {
                        //Filter by author, if appropriate
                        if (author != null)
                        {
                            if (author.Id.Equals(story.authorId))
                            {
                                 dtoStories.Add(DtoStory.lightDtoFromStory(story));
                            }
                        }
                        else if(author == null && authorId == null)
                        {
                            dtoStories.Add(DtoStory.lightDtoFromStory(story));
                        }
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
                    Story story = DtoStory.newStoryFromDto(dtoAddStory);
                    story.DatePublished = DateTime.UtcNow;
                    story.DateUpdated = DateTime.UtcNow;

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
                    story.ImageUrl = dto.story.imageUrl;

                    //Set category id
                    if (dto.story.category != null)
                    {
                        if (dto.story.category.categoryId != null)
                        {
                            story.CategoryId = dto.story.category.categoryId;
                        }
                    }

                    //Set author id
                    if (dto.story.author != null)
                    {
                        if (dto.story.author.Id != null)
                        {
                            story.authorId = dto.story.author.Id;
                        }
                    }

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
