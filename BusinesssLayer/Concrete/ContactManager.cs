using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public List<Contact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListbyFilter(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
