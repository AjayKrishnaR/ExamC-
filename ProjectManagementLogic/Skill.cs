using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLogic
{
    public class Skill : Employee
    {
        public string SkillCode;
        public string SkillName;
        public double SkillExperience;

        public Skill GetSkill(string _SkillCode, string _SkillName, double _SkillExperience)
        {
            var NewSkill = new Skill
            {
                SkillCode = _SkillCode,
                SkillName = _SkillName,
                SkillExperience = _SkillExperience,
            };
            return NewSkill;
        }



        //public void AddSkill(string EmployeeName, string SkillName)
        //{
        //    Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //    dictionary.Add(EmployeeName, SkillName);
        //}
    }



}
