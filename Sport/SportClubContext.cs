using System.Data.Entity;
using Utils.Models;

namespace Sport
{
    public class SportClubContext:DbContext        
    {
        public SportClubContext() : base("Connect")
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet<ClientCard> ClientCards { get; set; }
        public DbSet<TrainingKind> Trainings { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
