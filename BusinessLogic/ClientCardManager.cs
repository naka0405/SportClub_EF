using Sport;
using Utils.Interfaces;
using Utils.Models;

namespace BusinessLogic
{
    public class ClientCardManager
    {
        private readonly IClientCardRepozitory clientCardRepozitory;
        public ClientCardManager()
        {
            clientCardRepozitory = new RepozClientCardDAL();
        }

        public void AddClientCard(ClientCard card)
        {
            clientCardRepozitory.AddClient(card);
        }

        public void DeleteClientCard(int id)
        {
            clientCardRepozitory.DeleteClientById(id);
        }

        public void GetAllClientCards()
        {
            clientCardRepozitory.GetClientCards();
        }        
    }
}
