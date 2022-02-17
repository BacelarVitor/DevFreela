using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public abstract class BaseEntitiy
    {
        protected BaseEntitiy()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
    }
}