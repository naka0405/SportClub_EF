using Sport;
using Models;
using Interfaces;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ClientCardManager:IClientCardBL
    {
        private readonly IClientCardRepozitory clientCardRepozitory;
        public ClientCardManager()
        {
            clientCardRepozitory = new RepozClientCardDAL();
        }


        public void AddClientCard(ClientCardBL cardBL)
        {
            var card = new ClientCard()
            {              
                FirstName = cardBL.FirstName,
                LastName = cardBL.LastName,
                Telephone = cardBL.Telephone
            };
            clientCardRepozitory.AddClient(card);
        }

        public void DeleteClientCardById(int id)
        {
            clientCardRepozitory.DeleteClientById(id);
        }

        public List<ClientCardBL> GetClientCards()
        {
            var listBL = new List<ClientCardBL>();
            var listCards= clientCardRepozitory.GetClientCards();
            foreach (var c in listCards)
            {
                var clientCardBL = new ClientCardBL()
                {
                    ID=c.ID,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Telephone = c.Telephone
                };
                listBL.Add(clientCardBL);
            }
                return listBL;
        }
    }
}
