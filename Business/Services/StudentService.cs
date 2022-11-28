using Business.Interfaces;
using DataAccess.Repositories;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class StudentService : IStudent
    {
       private StudentRepository studentRepository { get; }
       private GroupService groupService { get; }
        private static int count;
        public StudentService()
        {
            studentRepository = new StudentRepository();
            groupService = new GroupService();
        }
        public Student Create(Student student, String groupName)
        {
            Group dbGroup = groupService.Get(groupName);
            if (dbGroup!=null)
            {
                student.Group = dbGroup;
                student.id = count;
                studentRepository.Create(student);
                count++;
                return student;
            }
            else
            {
                return null;
            }

        }
        public List<Student> GetAll(string groupName)
        {
            Group dbGroup = groupService.Get(groupName);
            if (dbGroup != null)
            {
                return studentRepository.GetAll(s => s.Group.name == dbGroup.name);
            }
            else
            {
                return null;
            }

        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get(string name)
        {
            throw new NotImplementedException();
        }

       

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Update(Student student, Student groupName)
        {
            throw new NotImplementedException();
        }

        public Student Create(Student student, Student groupName)
        {
            throw new NotImplementedException();
        }
    }
}
