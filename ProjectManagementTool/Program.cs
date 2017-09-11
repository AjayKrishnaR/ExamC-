using ProjectManagementLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool
{
    //Programmed By:
    //AJAY KRISHNA R

    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string ProjectCode;
            string ProjectName;
            string SkillCode;
            string SkillName;
            double SkillExperience;
            string EmployeeCode;
            string EmployeeName;
            double EmployeeExperience;
            int EmployeeAge;
            List<Employee> employee = new List<Employee>();
            List<Skill> skill = new List<Skill>();
            List<Project> project = new List<Project>();
            Dictionary<string, string> dictionaryproject = new Dictionary<string, string>();
            Dictionary<string, string> dictionaryskill = new Dictionary<string, string>();



            do
            {
                //MENU DISPLAY
                Console.WriteLine("********************PROJECT MANAGEMENT TOOL*************************");
                Console.WriteLine("1.ADD PROJECT");
                Console.WriteLine("2.ADD SKILL");
                Console.WriteLine("3.ADD EMPLOYEE");
                Console.WriteLine("4.ADD SKILL TO EMPLOYEE");
                Console.WriteLine("5.MAP EMPLOYEE TO PROJECT");
                Console.WriteLine("6.SEARCH EMPLOYEE BY NAME");
                Console.WriteLine("7.SEARCH EMPLOYEE BY PROJECT");
                Console.WriteLine("8.SEARCH EMPLOYEE BY SKILL");
                Console.WriteLine("9.EXIT");
                Console.WriteLine("");
                Console.WriteLine("Enter You Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Add Projects to System
                        Console.WriteLine("Enter Project Code :");
                        ProjectCode = Console.ReadLine();
                        Console.WriteLine("Enter Project Name :");
                        ProjectName = Console.ReadLine();
                        Project obj1 = new Project();
                        var NewProject = obj1.GetProject(ProjectCode, ProjectName);
                        project.Add(NewProject);
                        break;
                    case 2:
                        //Add Skills to System
                        Console.WriteLine("Enter Skill Code :");
                        SkillCode = Console.ReadLine();
                        Console.WriteLine("Enter Skill Name :");
                        SkillName = Console.ReadLine();
                        Console.WriteLine("Enter Experience :");
                        SkillExperience = Convert.ToDouble(Console.ReadLine());
                        Skill obj2 = new Skill();
                        var NewSkill = obj2.GetSkill(SkillCode, SkillName, SkillExperience);
                        skill.Add(NewSkill);
                        break;
                    case 3:
                        //Add Employees to System
                        Console.WriteLine("Enter Employee Code :");
                        EmployeeCode = Console.ReadLine();
                        Console.WriteLine("Enter Employee Name :");
                        EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter Employee Experience :");
                        EmployeeExperience = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Employee Age :");
                        EmployeeAge = Convert.ToInt32(Console.ReadLine());
                        Employee obj3 = new Employee();
                        var addnew = obj3.AddEmployee(EmployeeCode, EmployeeName, EmployeeExperience, EmployeeAge);
                        employee.Add(addnew);
                        break;
                    case 4:
                        //Add Skill To A Employee
                        Console.WriteLine("Enter Employee Code :");
                        EmployeeCode = Console.ReadLine();
                        Console.WriteLine("Enter Skill Code :");
                        SkillCode = Console.ReadLine();
                        Skill obj4 = new Skill();
                        dictionaryskill.Add(EmployeeCode, SkillCode);

                        break;
                    case 5:
                        //Map Employees To project Using Dictionary
                        Console.WriteLine("Enter Employee Name :");
                        EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter Project Name :");
                        ProjectName = Console.ReadLine();
                        Project obj5 = new Project();
                        dictionaryproject.Add(EmployeeName, ProjectName);
                        break;
                    case 6:
                        // Search Employee By Name
                        Console.WriteLine("Enter Employee Name :");
                        EmployeeName = Console.ReadLine();
                        // Console.WriteLine("The Employee Details Includes");
                        Employee obj6 = new Employee();
                        obj6.EmployeeDetailsDisplay(EmployeeName, employee);


                        break;
                    case 7:
                        //Search Employee By Project
                        Console.WriteLine("Enter Project Name :");
                        ProjectName = Console.ReadLine();
                        // Console.WriteLine("The Employee Details Includes");
                        Project obj7 = new Project();
                        if (dictionaryproject.ContainsKey(ProjectName)) ;
                        {
                            foreach (KeyValuePair<string, string> pair in dictionaryskill)
                            {
                                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                            }
                        }

                        break;
                    case 8:
                        //Searching Employee By Skill
                        Console.WriteLine("Enter Employee Code :");
                        EmployeeCode = Console.ReadLine();
                        Console.WriteLine("Enter Skill Code :");
                        SkillCode = Console.ReadLine();
                        if (dictionaryskill.ContainsKey(EmployeeCode)) ;
                        {
                            foreach (KeyValuePair<string, string> pair in dictionaryskill)
                            {
                                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                            }
                        }

                        break;
                    case 9:
                        //Exit Condition
                        break;
                    default:
                        Console.WriteLine("Sorry Wrong Choice");
                        break;
                }

            } while (choice < 9);


        }
    }
}
