using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IStudent
    {
        Student Create(Student student, Student groupName);
        Student Delete(int id);
        Student Update(Student student, Student groupName);
        Student Get(int id);
        List<Student> Get(string name);
        List<Student> GetAll(string groupName);
        List<Student> GetAll();
    }
}
