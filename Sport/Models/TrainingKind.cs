using System.Collections.Generic;

namespace Models
{
    public class TrainingKind
    {
        public int ID { get; set; }
        public string TrainingName { get; set; }       

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ClientCard> Clients {get;set;}
        public TrainingKind()
        {
            Groups = new List<Group>();
            Clients = new List<ClientCard>();
        }
    }
}
