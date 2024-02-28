using BlogApp.Models;
using System.Collections.Generic;

namespace BlogApp.Services
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        Blog GetById(int id);
        Blog Create(Blog blog);

    }
}
