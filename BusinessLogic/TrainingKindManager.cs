using Sport;
using Interfaces;
using Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class TrainingKindManager:ITrainingBL
    {
        private readonly ITrainingRepozitory trainingRepozitory;
        public TrainingKindManager()
        {
            trainingRepozitory = new RepozTrainingKindDAL();
        }

      
        public List<TrainingKind> GetAllKindsOfTraining()
        {
            var allTrainings= trainingRepozitory.GetAllKindsOfTraining();

            return allTrainings;
        }

       public void AddClientForTraining(int trainingKindId, int id)
        {
            trainingRepozitory.AddClientForTraining(trainingKindId, id);
        }

        public void AddNewKindOfTraining(TrainingKindBL newKind)
        {
            var trainingKind = new TrainingKind() { TrainingName = newKind.TrainingName };
            trainingRepozitory.AddNewKindOfTraining(trainingKind);
        }

        public void RemovingKindOfTrainingById(int id)
        {
            trainingRepozitory.RemovingKindOfTrainingById(id);
        }

    }
}
