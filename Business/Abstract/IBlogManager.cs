using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        void Add(Blog blog);
        void Remove(Blog blog,int id);
        void Update(Blog blog,int id);
        List<Blog> GetAllBlog();
        Blog GetBlogById(int id);
    }
}
