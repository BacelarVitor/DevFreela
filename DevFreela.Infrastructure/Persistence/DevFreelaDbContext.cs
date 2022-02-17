using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>() 
            {
                new Project("Help Me Rent", "Project that aims to help people find a place to live in a exchange program.", 1, 1, 10000m), 
                new Project("Get the money", "Project that aims to help people to save the necessary amount to make an exchange program.", 1, 1, 15000m),
                new Project("Let's bet", "Project for two friends make bets between than in a fairly and secure way", 1, 1, 35000m),
            };

            Users = new List<User>()
            {
                new User("Vitor", "Bacelar de Paula Augusto", "vitor.bacelar@protonmail.com" ,new DateTime(1997, 04, 10)),
                new User("Matheus", "Ribeiro", "ribeiro.horse@protonmail.com", new DateTime(1998, 04, 13)),
                new User("Wellisther", "Nunes", "taldo.sther@protonmail.com", new DateTime(2000, 03, 15)),
            };

            Skills = new List<Skill>()
            {
                new Skill(".Net Core"),
                new Skill("Angular 2+"),
                new Skill("C#"),
            };
        }
        public IList<Project> Projects { get; set; }
        public IList<User> Users { get; set; }
        public IList<Skill> Skills { get; set; }
    }
}
