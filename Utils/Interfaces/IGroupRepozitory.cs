using System.Collections.Generic;
using Utils.Models;

namespace Utils.Interfaces
{
    public interface IGroupRepozitory
    {
        void AddNewGroup(Group group);
        void AddGroupForTraining(string trainungName, Group group);
        void DeleteGroupById(int id);
        List<Group> GetGroupsByTrainingName(string name);
    }
}
