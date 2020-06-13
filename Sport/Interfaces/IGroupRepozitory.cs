using System.Collections.Generic;
using Models;

namespace Interfaces
{
    public interface IGroupRepozitory
    {
        void AddNewGroup(Group group);
        void AddGroupForTraining(int trainungId, Group group);
        void DeleteGroupById(int id);
        List<Group> GetGroupsByTrainingId(int id );
    }
}
