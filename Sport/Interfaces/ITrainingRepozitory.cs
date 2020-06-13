using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITrainingRepozitory
    {
        void AddNewKindOfTraining(TrainingKind newKind);
        void RemovingKindOfTrainingById(int id);
        List<TrainingKind> GetAllKindsOfTraining();
        void AddClientForTraining(int TrainingId,int ClientId);        
    }
}
