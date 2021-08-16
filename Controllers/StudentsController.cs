using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataWebService.Models;
using ODataWebService.Repositories;

namespace ODataWebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ODataController
    {
        private readonly SchoolContext _db;

        public StudentsController(SchoolContext context)
        {
            _db = context;
        }
        
        [EnableQuery]
        public IActionResult Get() => Ok(_db.Students);
        
        [EnableQuery]
        public IActionResult Get(int key) => Ok(_db.Students.FirstOrDefault(c => c.Id == key));

        public IActionResult Post([FromBody] Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return Created(student);
        }
        
        [HttpPut]
        public IActionResult Update([FromBody] Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
            return Ok(student);
        }
        
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Student student = _db.Students.FirstOrDefault(x => x.Id == id);
            
            if (student == null) return NotFound();
            
            _db.Students.Remove(student);
            _db.SaveChanges();
                
            return Ok();

        }


        
    }
}