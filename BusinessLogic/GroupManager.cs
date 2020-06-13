using Sport;
using System.Collections.Generic;
using Interfaces;
using Models;

namespace BusinessLogic
{
    public class GroupManager : IGroupBL
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

        public List<GroupBL> GetGroupsByTrainingId(int id)
        {
            var listBL = new List<GroupBL>();
            var list = groupRepozitory.GetGroupsByTrainingId(id);
            foreach (var gr in list)
            {
                var groupBL = new GroupBL()
                {
                    ID = gr.ID,
                    TrainerName = gr.TrainerName,
                    StartTime = gr.StartTime,
                    TrainingKindId=gr.TrainingKindId,
                    Training=gr.Training
                };
                listBL.Add(groupBL);
            }
            return listBL;
        }
    }
}

