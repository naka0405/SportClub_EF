﻿namespace Models
{
    public class GroupBL
    {
        public int ID { get; set; }
        public string TrainerName { get; set; }
        public int ClassNumber { get; set; }
        public string StartTime { get; set; }
        public int TrainingKindId { get; set; } 
        public TrainingKind Training { get; set; }
    }
}
