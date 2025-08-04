
using DataAcsessLayer.Abstract;
using DataAcsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAcsessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
    }
}
