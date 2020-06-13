using System;
using System.Linq;
using Models;
using Interfaces;
using System.Collections.Generic;

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

        public List<TrainingKind> GetAllKindsOfTraining()
        {
            using (ctx)
            {
                var allKindsOfTraining = ctx.Trainings.ToList();                
                return allKindsOfTraining;               
            }
        }

        public void RemovingKindOfTrainingById(int id)
        {
            var training = ctx.Trainings.Where(x => x.ID == id).FirstOrDefault();

            ctx.Trainings.Remove(training);

            ctx.SaveChanges();
        }

        public void AddClientForTraining(int trainingKindId, int id)
        {
            using (ctx)
            {
                var client= ctx.ClientCards.Where(x => x.ID == id).First();
                var selectTraining = ctx.Trainings.Where(x => x.ID == trainingKindId).FirstOrDefault();
                selectTraining.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
    }
}
