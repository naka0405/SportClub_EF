using System.Collections.Generic;
using System.Linq;
using Utils.Interfaces;
using Utils.Models;

namespace Sport
{
    public class RepozGroupDAL : IGroupRepozitory
    {
        private SportClubContext ctx;
        public RepozGroupDAL()
        {
            ctx = new SportClubContext();
        }

        public void AddNewGroup(Group group)
        {
            using (ctx)
            {
                ctx.Groups.Add(group);
                ctx.SaveChanges();
            }

        }
        public void AddGroupForTraining(string trainingName, Group group)
        {
            using(ctx)
            {
                var training = ctx.Trainings.Where(x => x.TrainingName == trainingName).FirstOrDefault();
                training.Groups.Add(group);
                ctx.SaveChanges();
            }
        }

        public void DeleteGroupById(int id)
        {
            using(ctx)
            {
                var selectGroup = ctx.Groups.Where(gr => gr.ID == id).FirstOrDefault();
                ctx.Groups.Remove(selectGroup);
                ctx.SaveChanges();
            }
        }

        public List<Group> GetGroupsByTrainingName(string name)
        {
            using (ctx)
            {
                var training = ctx.Trainings.Where(x => x.TrainingName == name).FirstOrDefault();
                var list = ctx.Groups.Where(x => x.TrainingId == training.ID).ToList();
            return list;
            }                
        }
    }
}
