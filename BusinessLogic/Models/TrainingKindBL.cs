using System.Collections.Generic;

namespace Models
{
    public class TrainingKindBL
    {
        public int ID { get; set; }
        public string TrainingName { get; set; }       

        public virtual ICollection<GroupBL> Groups { get; set; }
        public virtual ICollection<ClientCardBL> Clients {get;set;}
        public TrainingKindBL()
        {
            Groups = new List<GroupBL>();//
        }
    }
}
