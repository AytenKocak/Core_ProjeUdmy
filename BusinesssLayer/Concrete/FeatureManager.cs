using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }

        public List<Feature> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetListbyFilter(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
