using System.Collections.Generic;
using Models;

namespace Interfaces
{
    public interface IGroupBL
    {
        void AddNewGroup(GroupBL group);
        void AddGroupForTraining(int idTraining, GroupBL group);
        void DeleteGroupById(int id);
        List<Group> GetGroupsByTrainingId(int id );
    }
}
