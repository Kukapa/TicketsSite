using TicketsSite.Data.Base;
using TicketsSite.Models;

namespace TicketsSite.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
            
        }

    }
}
