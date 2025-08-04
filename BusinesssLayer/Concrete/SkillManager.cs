using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetListbyFilter(Expression<Func<Skill, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
