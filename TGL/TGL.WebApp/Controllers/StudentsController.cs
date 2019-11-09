using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TGL.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        public StudentStore StudentStore { get; set; }
        public StudentsController(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get() //get todo
        {
            var students = StudentStore.GetStudents();
            return Ok(students);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id) //get uno en especial
        {
            var student = StudentStore.GetStudentById(id);
            return Ok(student);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Student student) //post crear uno nuevo
        {
            StudentStore.AddStudent(student);
            return Ok();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]Student student) //update
        {
            student.Id = id;
            StudentStore.EditStudent(student);
            return Ok();
        }
        /// <summary>
        /// Metodo para eliminar un estudiante por el identificador
        /// </summary>
        /// <param name="id">Identificador del estudiante</param>
        /// <returns>Retorna Ok si fue eliminado</returns>
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) //delete
        {
            StudentStore.DeleteStudent(id);
            return Ok();
        }
    }
}
