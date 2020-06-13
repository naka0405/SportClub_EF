using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITrainingBL
    {
        void AddNewKindOfTraining(TrainingKindBL newKind);
        void RemovingKindOfTrainingById(int id);
        List<TrainingKind> GetAllKindsOfTraining();
        void AddClientForTraining(int TrainingId,int ClientId);        
    }
}
