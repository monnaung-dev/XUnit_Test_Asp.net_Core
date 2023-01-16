using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject1;
using WebApi.Entity;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            UnitTest1 test = new UnitTest1();
            test.Test1();
            return Ok(await _studentService.GetStudentList());
        }
        
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int studentId)
        {
            return Ok(await _studentService.GetById(studentId));
        }

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(StudentEntity studentEntity)
        {
            await _studentService.AddStudent(studentEntity);
            return Ok();
        }

        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateStudent(StudentEntity studentEntity)
        {
            await _studentService.UpdateStudent(studentEntity);
            return Ok();
        }

        [HttpDelete("Delete Student")]
        public async Task<IActionResult> DeleteStudent(int studentId)
        {
            await _studentService.RemoveStudent(studentId);
            return Ok();
        }
    }
}
