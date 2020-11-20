using Domain.Model.Entities;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ITicketService
    {
        Task<Root> getStatusTicket(Ticket entity);
    }
}
