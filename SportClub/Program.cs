using BusinessLogic;
using System;
using System.Collections.Generic;
using Utils.Models;

namespace SportClub
{
    class Program
    {
        static void Main(string[] args)
        {           
            var clientCardManager = new ClientCardManager();
            var trainingManager = new TrainingKindManager();
            var groupManager = new GroupManager();
          //trainingManager.DeleteTraining(3);
           // var group1 = new Group() { TrainerName = "Borsheva L.", ClassNumber = 7, StartTime = "11-30" };
            var group2 = new Group() { TrainerName = "Vavilova M.", ClassNumber = 8, StartTime = "10-00" };
           //var group3 = new Group() { TrainerName = "Smirnov V.", ClassNumber = 2, StartTime = "17-30" };
            var group4 = new Group() { TrainerName = "Sokolov S.", ClassNumber = 1, StartTime = "19-50" };
            //var swimingPool = new TrainingKind() { TrainingName = "SwimingPool", Groups = new List<Group> { group1, group3 } };
            var fitness = new TrainingKind() { TrainingName = "Fitness", Groups = new List<Group> { group2, group4 } };

            //trainingManager.AddNewKindOfTraining(swimingPool);
            //trainingManager.AddNewKindOfTraining(fitness);
           // clientCardManager.AddClientCard(new ClientCard() { FirstName = "Anastasia", LastName = "Ttt", Telephone = 0509132306 });
            
           //clientCardManager.AddClientCard(new ClientCard() { FirstName = "Yulia", LastName = "Liapina", Telephone = 099789456, Training = new List<TrainingKind> { swimingPool, fitness } });
           //clientCardManager.GetAllClientCards();
            Console.WriteLine("========================");
            //trainingManager.GetAllTrainings();
            //clientCardManager.AddTrainingForClient("Ttt", fitness);
            //trainingManager.AddClientForTraining("SwimingPool", 1);
           var groups= groupManager.GetGroupsByTrainingName("fitness");
            foreach(var g in groups)
            {
                Console.WriteLine($"{g.Training.TrainingName.ToUpper()} = {g.ID}-{g.TrainerName}|class #{g.ClassNumber}|start: {g.StartTime}");
            }
        }
    }
}