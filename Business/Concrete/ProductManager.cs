using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _productDal;
        private readonly IProductPictureManager _productPictureManager;

        public ProductManager(IProductDal productDal, IProductPictureManager productPictureManager)
        {
            _productDal = productDal;
            _productPictureManager = productPictureManager;
        }


        public void AddProduct(AddProductDTO productDTO)
        {
            Product product = new()
            {
                Name = productDTO.Name,
                Brand = productDTO.Brand,
                Description = productDTO.Description,
                CategoryId = productDTO.CategoryId,
                Price = productDTO.Price,
                SalePrice = productDTO.SalePrice,
                SKU = productDTO.SKU,
                Summary = productDTO.Summary,
                CoverPhoto = productDTO.CoverPhoto
            };

            _productDal.Add(product);

            for (int i = 0; i < productDTO.ProductPicture.Count; i++)
            {
                productDTO.ProductPicture[i].ProductId = product.Id;
                _productPictureManager.AddProductPicture(productDTO.ProductPicture[i]);
            }
        }

        public List<ProductDTO> GetAllProductList()
        {
            return _productDal.GetAllProduct();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDal.FindById(id);
        }

        public void Remove(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
