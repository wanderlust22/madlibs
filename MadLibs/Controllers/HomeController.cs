using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form() { return View(); }


        [Route("/story")]
        public ActionResult Story(string noun, string verb, string name)
        {
            StoryVariable theStory = new StoryVariable();
            theStory.Noun = noun;
            theStory.Verb = verb;
            theStory.Name = name;
            return View(theStory);
        }
    }
}