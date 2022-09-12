using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CommentDal : EfEntityRepositoryBase<Comment, CosmetsyDbContext>, ICommentDal
    {
        public List<CommentDTO> GetAllComment()
        {
            using var context = new CosmetsyDbContext();

            var comments = context.Comments.Include(x => x.Product).ToList();

            List<CommentDTO> result = new();

            foreach (var comment in comments)
            {
                CommentDTO commentDTO = new()
                {
                    Id = comment.Id,
                    UserName = comment.UserName,
                    UserEmail = comment.UserEmail,
                    Review = comment.Review,
                    Ratings = comment.Ratings,
                    ProductName = comment.Product.Name,
                    ProductId = comment.ProductId
                };
                result.Add(commentDTO);
            }

            return result;
        }
    }
}
