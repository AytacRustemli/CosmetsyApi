using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBotanicalManager
    {
        void Add(Botanical botanical);
        void Remove(Botanical botanical, int id);
        void Update(Botanical botanical, int id);
        List<Botanical> GetAllBotanical();
        Botanical GetBotanicalById(int id);
    }
}
