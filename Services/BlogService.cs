using BlogApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogApp.Services
{
    public class BlogService : IBlogService
    {
        private readonly DataBaseContext _context;

        public BlogService(DataBaseContext context)
        {
            _context = context;
        }
        public Blog Create(Blog blog)
        {
            if(blog != null) {

                _context.Add(blog);
                _context.SaveChanges();
                return blog;
            }
            return null;
           // throw new System.NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _context.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(b => b.Id == id);
            //var blog = _context.Blogs.Find(id);
            //var blog = _context.Blogs.Where(b => b.Id == id);
            //var blog = _context.Blogs.SingleOrDefault(b => b.Id == id);

            return blog;

        }
    }
}
