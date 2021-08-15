using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataWebService.Repositories;

namespace ODataWebService.Controllers
{
    public class StudentsController : ODataController
    {
        private readonly SchoolContext _db;

        public StudentsController(SchoolContext context)
        {
            _db = context;
        }
        
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Students);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_db.Students.FirstOrDefault(c => c.Id == key));
        }
    }
}