using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetListbyFilter(Expression<Func<Experience, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
