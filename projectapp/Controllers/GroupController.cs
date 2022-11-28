using Business.Services;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helper;

namespace projectapp.Controllers
{
    public class GroupController
    {
        public GroupService groupService { get; }

        public GroupController()
        {
            groupService = new GroupService();
        }
        public void Create()
        {
            EnterName:
            Helper.Colortext(ConsoleColor.Yellow, "Please Enter Group Name");
            string names = Console.ReadLine();
            Helper.Colortext(ConsoleColor.Yellow, "Please enter maxsize");
            string sizes = Console.ReadLine();
            int maxsizes;
            bool is_True = int.TryParse(sizes, out maxsizes);
            if (is_True)
            {
                Group group = new Group { name = names, maxSize = maxsizes };
                if (groupService.Create(group) != null)
                {
                    Helper.Colortext(ConsoleColor.Green, $"{group.name}, success ceated");
                    return;
                }
                else
                {
                    Helper.Colortext(ConsoleColor.Red, "Artiq movcuddur");
                    goto EnterName;
                }
            }
            else
            {
                Helper.Colortext(ConsoleColor.Red, "Xais edirik diqqetli olun");
                goto EnterName;
            }
        }
        public void AllGroup()
        {
            Helper.Colortext(ConsoleColor.Yellow, "All Groups");
            foreach (Group item in groupService.GetAll())
            {
                Helper.Colortext(ConsoleColor.Cyan, $"{item.id} - {item.name}");
            }
        }
        public void Delete()
        {
            Helper.Colortext(ConsoleColor.Green, "Group id write");
            string input = Console.ReadLine();
            int groupid;
            bool IsTrue = int.TryParse(input, out groupid);
            if (IsTrue)
            {
                if (groupService.Delete(groupid) != null)
                {
                    Helper.Colortext(ConsoleColor.Green, "Group is Deleted :|");
                    return;
                }
                else
                {
                    Helper.Colortext(ConsoleColor.Red, $" {groupid} Is not Find :) ");
                    return;
                }
            }
            else
            {
                Helper.Colortext(ConsoleColor.Red, " oooopsssssss:((((");
            }
        }
        public void Maxsize()
        {
            Helper.Colortext(ConsoleColor.Cyan, "Enter group size");
            string input = Console.ReadLine();
            int maxsize;
            bool istrue = int.TryParse(input, out maxsize);
            if (istrue)
            {
                Helper.Colortext(ConsoleColor.White, $"{maxsize} is group which size ");
                foreach (var item in groupService.GetAll(maxsize))
                {
                    Helper.Colortext(ConsoleColor.White, item.name );                  
                }
                return;
            }
            Helper.Colortext(ConsoleColor.White, "please select correct");
        }
    }
}
