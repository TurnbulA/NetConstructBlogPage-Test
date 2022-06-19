using Microsoft.AspNetCore.Mvc;
using NetConstructBlogPage.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static NetConstructBlogPage.Models.Blog;

namespace NetConstructBlogPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using(StreamReader sr = new StreamReader("./Data/Blog-Posts.json"))
            {
                return View();
            }
            
        }

        public IActionResult BlogA()
        {
            using (StreamReader sr = new StreamReader("./Data/Blog-Posts.json"))
            {
                Root blogs = JsonConvert.DeserializeObject<Root>(sr.ReadToEnd());
                return View(blogs);
            }
        }
        public IActionResult BlogB()
        {
            using (StreamReader sr = new StreamReader("./Data/Blog-Posts.json"))
            {
                Root blogs = JsonConvert.DeserializeObject<Root>(sr.ReadToEnd());
                return View(blogs);
            }
        }
        public IActionResult BlogC()
        {
            using (StreamReader sr = new StreamReader("./Data/Blog-Posts.json"))
            {
                Root blogs = JsonConvert.DeserializeObject<Root>(sr.ReadToEnd());
                return View(blogs);
            }
        }
        [HttpPost]
        public JsonResult CreateComment(comment Comment)
        {
            Comment.date = DateTime.Now;
            //<- Attempt to write to JSON file ->
            //var filePath = "./Data/Blog-Posts.json";
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    dynamic blogs = JsonConvert.DeserializeObject<Root>(sr.ReadToEnd());
                
            //    foreach(var item in blogs.BlogPosts)
            //    {
            //        if(item.id == Comment.blogId)
            //        {
            //            comment comment = new comment()
            //            {
            //                name = Comment.name,
            //                date = Comment.date,
            //                emailAddress = Comment.emailAddress,
            //                message = Comment.message,
            //            };

            //            string jsonData = JsonConvert.SerializeObject(comment);
            //            var write = blogs.WriteAllText(filePath, jsonData);
            //            return Json(jsonData);
            //        }
            //    }
            //}

            return Json(Comment);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}