using Blazor_Advance.Data.Interface;
using Blazor_Advance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Advance.Data.Services
{
    public class StudentService : ISudent
    {
        public List<Student> GetStudent()
        {
            try
            {
                using (var context = new StudentContext())
                {
                    var list = context.Student.ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Student GetStudentById(int id)
        {
            try
            {
                using (var context = new StudentContext())
                {

                    Student employee = context.Student.FirstOrDefault(e => e.StudentId == id);
                    return employee;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Student student)
        {
            try
            {
                using (var context = new StudentContext())
                {

                    context.Student.Add(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Student student)
        {
            try
            {

                using (var context = new StudentContext())
                {
                    context.Student.Update(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(Student student)
        {
            try
            {

                using (var context = new StudentContext())
                {
                    context.Student.Remove(student);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
