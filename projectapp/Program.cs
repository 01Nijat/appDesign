using Business.Services;
using Entities.models;
using projectapp.Controllers;
using System;
using Utilies.Helper;

namespace projectapp
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupController groupController = new GroupController();
            StudentController studentController= new StudentController();
                
            while (true)
            {
                ShowMenu();
                string selectedmenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedmenu,out menu);
                if (isTrue && menu>=1 && menu<=9)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateGroup:
                            groupController.Create();
                            break;
                        case (int)Helper.Menu.UpdateGroup:
                            break;
                        case (int)Helper.Menu.DeleteGroup:
                            groupController.Delete();
                            break;
                        case (int)Helper.Menu.GetWithIdGroup:
                            break;
                        case (int)Helper.Menu.GetGroupWithName:
                            break;
                        case (int)Helper.Menu.AllGroup:
                            groupController.AllGroup();
                            break;
                        case (int)Helper.Menu.GetGroupWithSize:
                            groupController.Maxsize();
                            break;
                        case (int)Helper.Menu.CreateStudent:
                            groupController.AllGroup();
                            studentController.Create();
                            break;
                        case (int)Helper.Menu.Getallstudentwithgroup:
                            groupController.AllGroup();
                            studentController.Getallstudentwithgroup();
                            break;

                        default:
                            break;
                    }
                }
                else if (menu==0)
                {
                    Helper.Colortext(ConsoleColor.Yellow, "Thanks");
                    break;
                }
                else
                {
                    Helper.Colortext(ConsoleColor.Red, "Xais edirik duzgunluyu yoxlayin");
                }
            }
        }
         static void ShowMenu()
        {
            Console.WriteLine("****************************************");
            Helper.Colortext(ConsoleColor.Cyan, "Xos Gelmisiz");
            Helper.Colortext(ConsoleColor.Green, "1-Create Group");
            Helper.Colortext(ConsoleColor.Green, "2-Update Group");
            Helper.Colortext(ConsoleColor.Green, "3-Delete Group");
            Helper.Colortext(ConsoleColor.Green, "4-Get With Id Group");
            Helper.Colortext(ConsoleColor.Green, "5-Get Group With Name");
            Helper.Colortext(ConsoleColor.Green, "6-All Group");
            Helper.Colortext(ConsoleColor.Green, "7-Get Group With size");
            Helper.Colortext(ConsoleColor.Green, "8-Create Student");
            Helper.Colortext(ConsoleColor.Green, "9-search Student");
            Helper.Colortext(ConsoleColor.Red, "0 - EXIT");
            Helper.Colortext(ConsoleColor.Yellow, "Select Number Please");
        }
    }
}
