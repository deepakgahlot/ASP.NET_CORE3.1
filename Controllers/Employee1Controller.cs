using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeInfo.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee1Controller : ControllerBase
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Employee
        [HttpGet]
        //[HttpGet]
        [Authorize]
        public ActionResult GetEmployees()       
        {
            return null;
        }
    }
}