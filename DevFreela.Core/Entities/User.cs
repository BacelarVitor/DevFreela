using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntitiy
    {
        public User(string fistName, string lastName, string email, DateTime birthDate)
        {
            FistName = fistName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            Active = true;
            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string FistName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Boolean Active { get; private set; }
        public IList<UserSkill> Skills { get; private set; }
        public IList<Project> OwnedProjects { get; private set; }
        public IList<Project> FreelanceProjects { get; private set; }

    }
}