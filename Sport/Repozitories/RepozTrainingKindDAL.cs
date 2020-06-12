using System;
using System.Linq;
using Utils.Interfaces;
using Utils.Models;

namespace Sport
{
    public class RepozTrainingKindDAL : ITrainingRepozitory
    {
        private SportClubContext ctx;
        public RepozTrainingKindDAL()
        {
            ctx = new SportClubContext();
        }
        public void AddNewKindOfTraining(TrainingKind newKind)
        {
        
            using (ctx)
            {                
                {
                    ctx.Trainings.Add(newKind);
                }               

                ctx.SaveChanges();
            }          
        }

        public void GetAllKindsOfTraining()
        {
            using (ctx)
            {
                foreach(var training in ctx.Trainings.ToList())
                {
                    Console.WriteLine($"{training.TrainingName}- ");                    
                }
               ctx.SaveChanges();
            }
        }

        public void RemovingKindOfTrainingById(int id)
        {
            var training = ctx.Trainings.Where(x => x.ID == id).FirstOrDefault();

            ctx.Trainings.Remove(training);

            ctx.SaveChanges();
        }

        public void AddClientForTraining(string trainingKind, int id)
        {
            using (ctx)
            {
                var client= ctx.ClientCards.Where(x => x.ID == id).First();
                var selectTraining = ctx.Trainings.Where(x => x.TrainingName == trainingKind).FirstOrDefault();
                selectTraining.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
    }
}
