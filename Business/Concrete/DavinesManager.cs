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
    public class DavinesManager : IDavinesManager
    {
        private readonly IDavinesDal _davinesDal;

        public DavinesManager(IDavinesDal davinesDal)
        {
            _davinesDal = davinesDal;
        }

        public void Add(Davines davines)
        {
            _davinesDal.Add(davines);
        }

        public List<Davines> GetAllDavines()
        {
            return _davinesDal.GetAll();
        }

        public Davines GetDavinesById(int id)
        {
            return _davinesDal.Get(x=>x.Id == id);
        }

        public void Remove(Davines davines, int id)
        {
            var current = _davinesDal.Get(x => x.Id == id);
            current.Picture = davines.Picture;
            _davinesDal.Delete(current);
        }

        public void Update(Davines davines, int id)
        {
            var current = _davinesDal.Get(x => x.Id == id);
            current.Picture = davines.Picture;
            _davinesDal.Update(current);
        }
    }
}
