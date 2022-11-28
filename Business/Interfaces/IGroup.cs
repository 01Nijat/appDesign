using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
   public interface IGroup
    {
        Group Create(Group group);
        Group Update(int id, Group group);
        Group Delete(int id);
        Group Get(int id);
        Group Get(string name);
        List<Group> GetAll();
        List<Group> GetAll(int maxSize);
    }
}
