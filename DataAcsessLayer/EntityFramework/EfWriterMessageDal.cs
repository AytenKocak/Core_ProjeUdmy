using DataAcsessLayer.Abstract;
using DataAcsessLayer.Concrete;
using DataAcsessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.EntityFramework
{
    public class EfWriterMessageDal : GenericRepository<WriterMessage>, IWriterMessageDal
    {
        public List<WriterMessage> GetbyFilter(Expression<Func<WriterMessage, bool>> filter)
        {
            using var c = new Context();
            return c.Set<WriterMessage>().Where(filter).ToList();
        }
        
    }
}

