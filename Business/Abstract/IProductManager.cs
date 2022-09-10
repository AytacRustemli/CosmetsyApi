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
        void UpdateProduct(AddProductDTO product, int id);
        void RemoveProduct(AddProductDTO product, int id);
        List<ProductDTO> GetAllProductList();
        ProductDTO GetProductById(int id);
    }
}
