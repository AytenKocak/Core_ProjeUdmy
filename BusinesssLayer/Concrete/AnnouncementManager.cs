using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announceentDal;

        public AnnouncementManager(IAnnouncementDal announceentDal)
        {
            _announceentDal = announceentDal;
        }

        public void TAdd(Announcement t)
        {
            _announceentDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announceentDal.Delete(t);
        }

        public Announcement TGetByID(int id)
        {
            return _announceentDal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announceentDal.GetList();
        }

        public List<Announcement> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetListbyFilter(Expression<Func<Announcement, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            _announceentDal.Update(t);
        }
    }
}
