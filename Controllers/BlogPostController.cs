using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi_sistema_blog.Contexts;
using webapi_sistema_blog.Models;

namespace webapi_sistema_blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostController : ControllerBase
    {
		private readonly BlogContext _context;

        public BlogPostController(BlogContext context)
        {
			_context = context;
		}

        [HttpPost]
        public IActionResult CreatePost(BlogPost post)
        {
            if (post == null)
            {
				return NoContent();
			}

			post.CreationDate = DateTime.Now;

			_context.Add(post);
			_context.SaveChanges();
			return Ok(post);
		}
	}
}