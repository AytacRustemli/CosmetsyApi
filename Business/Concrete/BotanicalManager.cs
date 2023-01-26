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
    public class BotanicalManager : IBotanicalManager
    {
        private readonly IBotanicalDal _botanicalDal;

        public BotanicalManager(IBotanicalDal botanicalDal)
        {
            _botanicalDal = botanicalDal;
        }

        public void Add(Botanical botanical)
        {
            _botanicalDal.Add(botanical);
        }

        public List<Botanical> GetAllBotanical()
        {
            return _botanicalDal.GetAll();
        }

        public Botanical GetBotanicalById(int id)
        {
            return _botanicalDal.Get(x=>x.Id == id);
        }

        public void Remove(Botanical botanical, int id)
        {
            var current = _botanicalDal.Get(x => x.Id == id);
            current.Name = botanical.Name;
            current.PhotoUrl = botanical.PhotoUrl;
            current.Title = botanical.Title;
            current.Description = botanical.Description;
            _botanicalDal.Delete(current);
        }

        public void Update(Botanical botanical, int id)
        {
            var current = _botanicalDal.Get(x => x.Id == id);
            current.Name = botanical.Name;
            current.PhotoUrl = botanical.PhotoUrl;
            current.Title = botanical.Title;
            current.Description = botanical.Description;
            _botanicalDal.Update(current);
        }
    }
}
