using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductManager
    {
        void AddProduct(AddProductDTO product);
        void Remove(Product product);
        List<ProductDTO> GetAllProductList();
        ProductDTO GetProductById(int id);
    }
}
