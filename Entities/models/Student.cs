using Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.models
{
   public class Student:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Group Group { get; set; }
    }
}
