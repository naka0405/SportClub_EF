using System.Collections.Generic;
using System.Data.Entity;
using Models;

namespace Sport
{
     public class Initializer: DropCreateDatabaseIfModelChanges<SportClubContext>
    {
        protected override void Seed(SportClubContext ctx)
        {   
            var groups = new List<Group> {
                new Group(){ TrainerName="Shkurkina U.", ClassNumber=7, StartTime="15-00" },
                new Group(){ TrainerName="Kolosov M.", ClassNumber=7, StartTime="10-00" }
                };
            var hipHop = new TrainingKind() { TrainingName = "HipHop", Groups = groups };
           
            var trainings = new List<TrainingKind>()
            {                
                new TrainingKind(){ TrainingName="HipHop", Groups=groups},
                new TrainingKind(){ TrainingName="BreakDance"}
            };
            var newClientCard = new ClientCard() { FirstName = "Galina", LastName = "Pulina", Telephone = 0509969375, Training = trainings };
            trainings[0].Clients.Add(newClientCard);
            trainings[1].Clients.Add(newClientCard);
            ctx.Groups.AddRange(groups);
            ctx.Trainings.AddRange(trainings);
            ctx.ClientCards.Add(newClientCard);           

            ctx.SaveChanges();
            base.Seed(ctx);
        }
    }
}
