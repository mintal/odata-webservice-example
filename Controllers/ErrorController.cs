using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData;

namespace ODataWebService.Controllers
{
    public class ErrorController : ODataController
    {
        [Route("/error")]
        public IActionResult Error() => Problem();
    }
}