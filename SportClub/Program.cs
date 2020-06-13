using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;

namespace SportClub
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCardManager = new ClientCardManager();
            var trainingManager = new TrainingKindManager();
            var groupManager = new GroupManager();
           // trainingManager.RemovingKindOfTrainingById(3);
           // var group1 = new GroupBL() { TrainerName = "Borsheva L.", ClassNumber = 7, StartTime = "11-30" };
            //var group2 = new GroupBL() { TrainerName = "Vavilova M.", ClassNumber = 8, StartTime = "10-00" };
            //var group3 = new GroupBL() { TrainerName = "Smirnov V.", ClassNumber = 2, StartTime = "17-30" };
            //var group4 = new GroupBL() { TrainerName = "Sokolov S.", ClassNumber = 1, StartTime = "19-50" };
            //var swimingPool = new TrainingKindBL() { TrainingName = "SwimingPool", Groups = new List<GroupBL> { group1, group3 } };
            //var fitness = new TrainingKindBL() { TrainingName = "Fitness", Groups = new List<GroupBL> { group2, group4 } };

            //trainingManager.AddNewKindOfTraining(swimingPool);
            //trainingManager.AddNewKindOfTraining(fitness);
            //clientCardManager.AddClientCard(new ClientCardBL() { FirstName = "Anastasia", LastName = "Ttt", Telephone = 0509132306 });

            //clientCardManager.AddClientCard(new ClientCardBL() { FirstName = "Yulia", LastName = "Liapina", Telephone = 099789456, Training = new List<TrainingKind> { swimingPool, fitness } });
            
            //var allClientCards=clientCardManager.GetClientCards();
            // foreach (var item in allClientCards)
            // {
            //     Console.WriteLine($"#{item.ID}|{item.FirstName} {item.LastName}|{item.Telephone}");
            // }
            //Console.WriteLine("========================");
            //var allTrainings = trainingManager.GetAllKindsOfTraining();
            //foreach (var t in allTrainings)
            //{
            //    Console.WriteLine($"{t.ID}-{t.TrainingName}");
            //}
               
                //trainingManager.AddClientForTraining(2, 1);
                var groups = groupManager.GetGroupsByTrainingId(3);
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Training.TrainingName.ToUpper()} = {g.ID}-{g.TrainerName}|class #{g.ClassNumber}|start: {g.StartTime}");
            }
        
        }
    }
}