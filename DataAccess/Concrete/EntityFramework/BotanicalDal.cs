using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class BotanicalDal : EfEntityRepositoryBase<Botanical, CosmetsyDbContext>, IBotanicalDal
    {
    }
}
