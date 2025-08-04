using Core_ProjeApi.DAL.ApiContext;
using Core_ProjeApi.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_ProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApıController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCateGoryList()
        {
             using var c = new Context();
            return Ok(c.Categories.ToList());

        }
        [HttpGet ("{id}")]
        public IActionResult CategoryGet(int id) 
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if( value==null)
            {
                return NotFound();
            }

            else
            { return Ok(value);   }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);

        }
        [HttpDelete]

        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if(value==null)
            {

                return NotFound();
            }
            else
            {

                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }


        }
        [HttpPut]

        public IActionResult UpDateCategory(Category p)
        {
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryId);

            if(value==null)
            {
             return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName; 
                c.Update(value);
                c.SaveChanges();
                return NoContent();


            }
        }

    }
}
