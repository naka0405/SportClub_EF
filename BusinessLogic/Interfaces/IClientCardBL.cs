using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientCardBL
    {
        void AddClientCard(ClientCardBL clientBL);
        void DeleteClientCardById(int id);
        List<ClientCardBL> GetClientCards();       
    }
}
