using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BlogManager : IBlogManager
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public List<Blog> GetAllBlog()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.Get(x => x.Id == id);
        }

        public void Remove(Blog blog,int id)
        {
            var current = _blogDal.Get(x => x.Id == id);
            current.Name = blog.Name;
            current.Picture = blog.Picture;
            current.Tags = blog.Tags;
            current.Style = blog.Style;
            _blogDal.Delete(current);
        }

        public void Update(Blog blog,int id)
        {
            var current = _blogDal.Get(x => x.Id == id);
            current.Name = blog.Name;
            current.Picture = blog.Picture;
            current.Tags = blog.Tags;
            current.Style = blog.Style;
            _blogDal.Update(current);
        }
    }
}
