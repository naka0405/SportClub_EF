using Utils.Models;

namespace Utils.Interfaces
{
    public interface IClientCardRepozitory
    {
        void AddClient(ClientCard client);
        void DeleteClientById(int id);
        void GetClientCards();       
    }
}
