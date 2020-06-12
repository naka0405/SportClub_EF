using Utils.Models;

namespace Utils.Interfaces
{
    public interface ITrainingRepozitory
    {
        void AddNewKindOfTraining(TrainingKind newKind);
        void RemovingKindOfTrainingById(int id);
        void GetAllKindsOfTraining();
        void AddClientForTraining(string trainingKind,int id);        
    }
}
