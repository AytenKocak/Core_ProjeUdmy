using DataAcsessLayer.Abstract;
using DataAcsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAcsessLayer.EntityFramework
{
   public class EfToDoListDal : GenericRepository<ToDoList>, IToDoListDal
    {
    }
}
