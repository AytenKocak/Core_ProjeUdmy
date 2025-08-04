
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
       
      
            ToDoListManager toDoListManager = new(new EfToDoListDal());

            public IViewComponentResult Invoke()
            {
            var values = toDoListManager.TGetList();
                return View(values);
            }
      

    }
}
