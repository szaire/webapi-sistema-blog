using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi_sistema_blog.Models;

namespace webapi_sistema_blog.Contexts
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

		public DbSet<BlogPost> BlogPosts { get; set; }
	}
}