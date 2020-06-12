using Sport;
using Utils.Interfaces;
using Utils.Models;

namespace BusinessLogic
{
    public class TrainingKindManager//реализует доступ к методам DAL
    {
        private readonly ITrainingRepozitory trainingRepozitory;
        public TrainingKindManager()
        {
            trainingRepozitory = new RepozTrainingKindDAL();
        }

        public void AddNewKindOfTraining(TrainingKind kind )
        {
            trainingRepozitory.AddNewKindOfTraining(kind);
        }

        public void DeleteTraining(int id)
        {
            trainingRepozitory.RemovingKindOfTrainingById(id);
        }

        public void GetAllTrainings()
        {
            trainingRepozitory.GetAllKindsOfTraining();
        }

       public void AddClientForTraining(string trainingKind, int id)
        {
            trainingRepozitory.AddClientForTraining(trainingKind, id);
        }
    }
}
