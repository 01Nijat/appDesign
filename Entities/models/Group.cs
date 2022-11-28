using Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.models
{
    public class Group:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int maxSize { get; set; }
    }
}
