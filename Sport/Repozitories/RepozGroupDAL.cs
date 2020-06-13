using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Models;

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
        public void AddGroupForTraining(int trainingId, Group group)
        {
            using(ctx)
            {
                var training = ctx.Trainings.Where(x => x.ID == trainingId).FirstOrDefault();
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

        public List<Group> GetGroupsByTrainingId(int id)
        {
            using (ctx)
            {
                var training = ctx.Trainings.Where(x => x.ID == id).FirstOrDefault();
                var list = ctx.Groups.Where(x => x.TrainingId == training.ID).ToList();
            return list;
            }                
        }
    }
}
