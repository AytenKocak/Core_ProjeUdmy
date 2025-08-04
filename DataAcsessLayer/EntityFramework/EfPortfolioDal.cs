
using DataAcsessLayer.Abstract;
using DataAcsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAcsessLayer.EntityFramework
{
    public class EFPortfolioDal : GenericRepository<Portfolio>, IPortfolioDal
    {
    }
}
