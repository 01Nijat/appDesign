using System;
using System.Collections.Generic;
using System.Text;
using Business.Services;
using Entities.models;
using Utilies.Helper;

namespace projectapp.Controllers
{
    public class StudentController
    {
        private StudentService studentService { get; }
        public StudentController()
        {
            studentService= new StudentService();
        }
        public void Create()
        {
            Helper.Colortext(ConsoleColor.Cyan, "Var olan grupu secin");
            string groupName=Console.ReadLine();
            Helper.Colortext(ConsoleColor.Cyan, "Enter the name");
            string name = Console.ReadLine();
            Helper.Colortext(ConsoleColor.Cyan, "Enter the surname");
            string surname = Console.ReadLine();
            Student student = new Student { name = name, surname = surname };
            Student nStu = studentService.Create(student, groupName);
            if (nStu!=null)
            {
                Helper.Colortext(ConsoleColor.Green, $"New student is created {nStu.name} {nStu.surname}");
                return;
            }
            else
            {
                Helper.Colortext(ConsoleColor.Red, $"dont search of group {groupName} ");
            }


        }
        public void Getallstudentwithgroup()
        {
            Helper.Colortext(ConsoleColor.Cyan, "Var olan grupu secin");
            string groupName = Console.ReadLine();
            List<Student> students = studentService.GetAll(groupName);
            if (students!=null)
            {
                foreach (var item in students)
                {
                    Helper.Colortext(ConsoleColor.Green, $"{item.id} - {item.name} {item.surname}");
                }
                return;
            }
            Helper.Colortext(ConsoleColor.Red, $"Couldnt find such as group - {groupName}");

        }
    }
}
