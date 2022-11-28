using DataAccess.Interfaces;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student ent)
        {
            try
            {
                Dbcontext.Students.Add(ent);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student ent)
        {
            try
            {
                Dbcontext.Students.Remove(ent);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student Get(Predicate<Student> filter = null)
        {
            try
            {
                return filter ==null ? Dbcontext.Students[0] : Dbcontext.Students.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            try
            {
                return filter == null ? Dbcontext.Students : Dbcontext.Students.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Student ent)
        {
            try
            {
                Student Dbstudent = Get(s => s.id == ent.id);
                Dbstudent = ent;
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
