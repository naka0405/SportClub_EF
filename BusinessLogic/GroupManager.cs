using Sport;
using System.Collections.Generic;
using Utils.Interfaces;
using Utils.Models;

namespace BusinessLogic
{
    public class GroupManager////реализует доступ к методам DAL
    {
        private readonly IGroupRepozitory groupRepozitory;
        public GroupManager()
        {
            groupRepozitory = new RepozGroupDAL();
        }


        public void AddNewGroup(Group group)
        {
            groupRepozitory.AddNewGroup(group);
        }

        public void AddGroupForTraining(string trainingName, Group group)
        {
            groupRepozitory.AddGroupForTraining(trainingName, group);
        }

        public void DeleteGroupById(int id)
        {
            groupRepozitory.DeleteGroupById(id);
        }

        public List<Group> GetGroupsByTrainingName(string name)
        {
            return groupRepozitory.GetGroupsByTrainingName(name);
        }
    }
}
