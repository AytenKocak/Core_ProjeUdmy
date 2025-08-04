using DataAcsessLayer.Abstract;
using DataAcsessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.EntityFramework
{
    public class EfWriterUserDal : GenericRepository<WriterUser>, IWriterUserDal
    {
    }
}
