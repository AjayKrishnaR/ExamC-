using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLogic
{
    public class Project : Employee
    {
        public string ProjectCode;
        public string ProjectName;

        public Project GetProject(string _ProjectCode, string _ProjectName)
        {
            var NewProject = new Project
            {
                ProjectCode = _ProjectCode,
                ProjectName = _ProjectName,
            };
            return NewProject;

        }

    

        //public void ProjectDetailsDisplay(IDictionary dictionaryproject)
        //{
        //    foreach (KeyValuePair<string, string> pair in dictionaryproject)
        //    {
                
        //        Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
        //    }
        //}


    }
}
