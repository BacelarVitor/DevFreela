using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntitiy
    {
        public Skill(string description)
        {
            Description = description;
        }
        public string Description { get; private set; }
    }
}