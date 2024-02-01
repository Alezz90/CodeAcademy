using CodeAcademyAPI.Data;
using CodeAcademyAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    //https://localhost:7040/api/ToDo/getListTodo
    public class ToDoController : ControllerBase
    {
        private readonly AcademyeeContext _context;

        /*  [HttpGet]
public IEnumerable<Todo> GetAll()
{
var todo = new List<Todo>()
{
new Todo { ID = 1, Title = "ForgotPassword", Description = " need search", CreatedDate = new DateTime() },
new Todo { ID = 2, Title = "ResetPassword", Description = " Dont think search", CreatedDate = new DateTime() },
new Todo { ID = 3, Title = "DeletUser", Description = " delete ", CreatedDate = new DateTime() },

};
return todo;

}*/

        public ToDoController(AcademyeeContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("createTodo")]
        public ActionResult create(Todo todo)
        {
            if(ModelState.IsValid)
            {
                _context.ToDo.Add(todo);
                _context.SaveChanges();
                return Ok(todo);
            }
            return BadRequest();
        }

        [HttpGet("getIDTodo/{id:int}")]
        public ActionResult getID(int id)
        {
            var todoList = _context.ToDo.Find(id);
            return Ok(todoList);
        }
      
        [HttpGet("getListTodo")]
        public ActionResult getAll()
        {
            var todoList = _context.ToDo.ToList();
            return Ok(todoList);
        }

        [HttpPut("updateListTodo")]
       
        public ActionResult UpdateID(Todo todo)
        {
          
           
                if (ModelState.IsValid)
                {
                    _context.ToDo.Update(todo);
                    _context.SaveChanges();

                    return Ok(_context.ToDo.ToList());
                }
            
           
            return BadRequest();
        }
        [HttpDelete("deleteListTodo/{id:int}")]
        public ActionResult delete(int id)
        {
            var todo = _context.ToDo.Find(id);
            _context.ToDo.Remove(todo);
            _context.SaveChanges();
            return Ok(_context.ToDo.ToList());
        }
    }
}
