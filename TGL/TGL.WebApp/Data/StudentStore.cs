using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Juan",
                LastName = "Gonzalez",
                Nit = "123456"

            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Carlos",
                LastName = "Sanchez",
                Nit = "1234567"

            });

            Students.Add(new Student
            {
                Id = Guid.NewGuid(),
                Age = 17,
                Name = "Pedro",
                LastName = "Sanchez",
                Nit = "12345678"

            });


        }

        internal void DeleteStudent(Guid id)
        {

            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }
    }
}
