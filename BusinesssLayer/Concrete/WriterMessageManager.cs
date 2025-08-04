using BusinesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListRecieverMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Recevier == p);
        }

        public List<WriterMessage> GetListSenderMessager(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMessageDal.GetList();
       }

        public List<WriterMessage> TGetListbyFilter(Expression<Func<WriterMessage, bool>> filter)
        {
            throw new NotImplementedException();
        }




        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
