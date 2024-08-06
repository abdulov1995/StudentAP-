using Microsoft.AspNetCore.Mvc;
using StudentAPİ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPİ
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private static List<Student> students=new List<Student>();
        [HttpGet("Get")]
        public List<Student>Get()
        {
            return students;
        }
        [HttpPost("Create")]
        public Student Create(Student student)
        {
            students.Add(student);
            return student;
        }
        [HttpPut("Update")]
        public void Update(int Id,Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == Id);
            updatedStudent.Name = student.Name;
            updatedStudent.Age = student.Age;
            //students.Add(student);
            //return student;
        }
        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            var student = students.FirstOrDefault(s => s.Id == Id);
            students.Remove(student);
        }
    }
}
