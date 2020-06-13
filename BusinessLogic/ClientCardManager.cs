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

        public List<ClientCard> GetClientCards()
        {
           return clientCardRepozitory.GetClientCards();
        }
    }
}
