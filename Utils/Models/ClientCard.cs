using System.Collections.Generic;


namespace Utils.Models
{
    public class ClientCard
    {       
        public ClientCard()
        {           
            Training = new List<TrainingKind>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }       
        public virtual List<TrainingKind> Training { get; set; }       

    }
}
