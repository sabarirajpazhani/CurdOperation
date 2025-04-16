using CurdProject.DB;
using CurdProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CurdProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db) 
        {
            _db = db;
        }

        [HttpPost]
        [Route("Create")]  //IActionResult - Multiple Data return type
        public IActionResult Create([FromBody]Student s1) //create,update [Frombody] pass
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);    
        }
    }
}
