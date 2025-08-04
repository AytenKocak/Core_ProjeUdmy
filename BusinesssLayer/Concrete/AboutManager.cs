using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class AboutManager : IAboutService
    {
       IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<About> TGetListbyFilter(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
