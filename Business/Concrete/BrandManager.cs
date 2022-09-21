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
    public class BrandManager : IBrandManager
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public List<Brand> GetAllBrand()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandById(int id)
        {
            return _brandDal.Get(x => x.Id == id);
        }

        public void Remove(Brand brand, int id)
        {
            var current = _brandDal.Get(x => x.Id == id);
            current.Name = brand.Name;
            _brandDal.Delete(current);
        }

        public void Update(Brand brand, int id)
        {
            var current = _brandDal.Get(x => x.Id == id);
            current.Name = brand.Name;
            _brandDal.Update(current);
        }
    }
}
