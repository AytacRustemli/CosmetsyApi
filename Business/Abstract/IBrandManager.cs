using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandManager
    {
        void Add(Brand brand);
        void Remove(Brand brand, int id);
        void Update(Brand brand, int id);
        List<Brand> GetAllBrand();
        Brand GetBrandById(int id);
    }
}
