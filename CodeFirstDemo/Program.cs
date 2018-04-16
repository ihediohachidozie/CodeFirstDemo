using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new BlogDbContext();
            
            var post = new Post()
            {
                Body = "Body 2",
                DatePublished = DateTime.Now,
                Title = "Title 2"
            };
            ctx.Posts.Add(post);
            ctx.SaveChanges();
            Console.Write("Data added Successfully!");
            Console.ReadKey();
            
        }
    }
}
