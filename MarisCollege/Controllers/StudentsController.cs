using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarisCollege.Models;
using MarisCollege.Database;

namespace MarisCollege.Controllers
{
    [Route("Api/Students")]
    public class StudentsController : Controller
    {
        private StudentDataContext context;
        public StudentsController(StudentDataContext context)
        {
            this.context = context;
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult AddNew([FromBody]Student model)
        {
            if(this.context.Students.Where(w=> w.Email == model.Email).Any())
            {
                return BadRequest(); 
            }
            this.context.Students.Add(model);
            this.context.SaveChanges();
            return Ok();
        }

        [Route("All")]
        [HttpGet]
        public List<Student> GetAll()
        {
            return this.context.Students.ToList();
        }
    }
}
