using Business.Interfaces;
using DataAccess.Repositories;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GroupService : IGroup
    {
        public GroupRepository groupRepository { get; set; }
        private static int Count{ get; set; }
        public GroupService()
        {
            groupRepository = new GroupRepository();
        }
        public Group Create(Group group)
        {
            try
            {
                group.id = Count;
                Group isExist = groupRepository.Get(g => g.name.ToLower() == group.name.ToLower());
                if (isExist != null)
                    return null;
                groupRepository.Create(group);
                Count++;
                return group;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Group Delete(int id)
        {
            Group datagroup = groupRepository.Get(g => g.id == id);
            if (datagroup!=null)
            {
                groupRepository.Delete(datagroup);
                return datagroup;
            }
            else
            {
                return null;
            }
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public Group Get(string name)
        {
            return groupRepository.Get(g => g.name.ToLower() == name.ToLower());
        }

        public List<Group> GetAll()
        {
            return groupRepository.GetAll();
        }

        public List<Group> GetAll(int maxSize)
        {
           return groupRepository.GetAll(g => g.maxSize == maxSize);
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();
        }

        internal Group Get(Student groupName)
        {
            throw new NotImplementedException();
        }
    }
}
