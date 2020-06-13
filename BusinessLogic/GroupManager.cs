using Sport;
using System.Collections.Generic;
using Interfaces;
using Models;

namespace BusinessLogic
{
    public class GroupManager:IGroupBL
    {
        private readonly IGroupRepozitory groupRepozitory;
        public GroupManager()
        {
            groupRepozitory = new RepozGroupDAL();
        }


        public void AddNewGroup(GroupBL groupBL)
        {
            var group = new Group()
            {
                TrainerName = groupBL.TrainerName,
                ClassNumber = groupBL.ClassNumber,
                StartTime = groupBL.StartTime
            };
            groupRepozitory.AddNewGroup(group);
        }

        public void AddGroupForTraining(int trainingId, GroupBL groupBL)
        {
            var group = new Group() { TrainerName = groupBL.TrainerName, ClassNumber = groupBL.ClassNumber, StartTime = groupBL.StartTime }; 
            groupRepozitory.AddGroupForTraining(trainingId, group);
        }

        public void DeleteGroupById(int id)
        {
            groupRepozitory.DeleteGroupById(id);
        }

        public List<Group> GetGroupsByTrainingId(int id)
        {
            return groupRepozitory.GetGroupsByTrainingId(id);
        }
    }
}
