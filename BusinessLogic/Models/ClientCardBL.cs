using System.Collections.Generic;


namespace Models
{
    public class ClientCardBL

    {       
        public ClientCardBL()
        {           
            Training = new List<TrainingKindBL>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }       
        public virtual List<TrainingKindBL> Training { get; set; }       

    }
}
