using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
        }
        [HttpGet("{id:int}")] 
        public Student GetStudentbyId(int id) 
        { 
            return CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
