using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetListbyFilter(Expression<Func<Portfolio, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
