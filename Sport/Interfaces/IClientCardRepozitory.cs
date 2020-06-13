using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientCardRepozitory
    {
        void AddClient(ClientCard client);
        void DeleteClientById(int id);
        List<ClientCard> GetClientCards();       
    }
}
