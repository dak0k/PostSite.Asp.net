using Microsoft.AspNetCore.Mvc;
using PostsSite.Mocks;
using PostsSite.Models;

namespace PostsSite.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;
        public PostController(IPostService postService)
        {
            this._postService = postService;
        }
        public IActionResult Index()
        {
            return View(_postService);
        }

        /// <summary>
        /// This is Create page inside of Post folder
        /// </summary>
        /// <returns>View</returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// This <span style="color:blue">Store</span> has <span style="color:red">POST</span> method <br></br>
        /// Creating post
        /// </summary>
        /// <returns>IActionResult, String</returns>
        [HttpPost]
        public IActionResult Store(string author, string title, string description)
        {
            Post post = new Post()
            {
                
               author = author,
               title = title,
               description = description,
               created = DateTime.Now,
            };
            _postService.Posts.Add(post);
            return RedirectToAction("Index");
        }
    }
}
