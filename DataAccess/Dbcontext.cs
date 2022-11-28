using Entities.models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public static class Dbcontext
    {
        public static List<Student> Students { get; }
        public static List<Group> Groups { get; }
         static Dbcontext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
    }
}
