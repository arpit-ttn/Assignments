using Blazor_Advance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Advance.Data.Interface
{
    interface ISudent
    {
        public List<Student> GetStudent();
        public Student GetStudentById(int id);
        public bool Insert(Student student);
        public bool Update(Student student);
        public bool Delete(Student student);
    }
}
