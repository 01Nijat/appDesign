using DataAccess.Interfaces;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
   public class GroupRepository: IRepository <Group>
    {
        public bool Create(Group ent)
        {
            try
            {
                Dbcontext.Groups.Add(ent);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group ent)
        {
            try
            {
                Dbcontext.Groups.Remove(ent);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(Predicate<Group> filter = null)
        {
            try
            {
                return filter == null ? Dbcontext.Groups[0] : Dbcontext.Groups.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            try
            {
                return filter == null ? Dbcontext.Groups : Dbcontext.Groups.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Group ent)
        {
            try
            {
                Group DbGroup = Get(s => s.id == ent.id);
                DbGroup = ent;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    

    }
}
