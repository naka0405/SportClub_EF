using System;
using System.Linq;
using Utils.Interfaces;
using Utils.Models;

namespace Sport
{
    public class RepozClientCardDAL : IClientCardRepozitory
    {
       
        private SportClubContext ctx;
        public RepozClientCardDAL()
        {
            ctx = new SportClubContext();
        }
        public void AddClient(ClientCard client)
        {
            //    SampleContext context = new SampleContext();

            //    return context.Customers.Find(id)
            //        ?? context.Customers.Add(new Customer
            //        {
            //            FirstName = "...",
            //            LastName = "...",
            //            Age = 40
            //        });
            using (ctx)
            {
                if (!ctx.ClientCards.ToList().Contains(client))
                    {
                    ctx.ClientCards.Add(client);
                    Console.WriteLine($"ID={client.ID}");

                    ctx.SaveChanges();
                    Console.WriteLine($"ID={client.ID}");
                }
                Console.WriteLine("Such a client already exists" );
            }
        }

        public void DeleteClientById(int id)
        {
            using (ctx)
            {
                var clientCard = ctx.ClientCards.Where(x => x.ID == id).FirstOrDefault();

                ctx.ClientCards.Remove(clientCard);

                ctx.SaveChanges();
             }
        }

        public void GetClientCards()
        {
            using (ctx)
            {
                var clientCards = ctx.ClientCards.ToList();

                foreach (var item in clientCards)
                {
                    Console.WriteLine($"#{item.ID}|{item.FirstName} {item.LastName}|{item.Telephone}");
                }
            }
        } 
    }
}
