using TicketsSite.Data.Base;
using TicketsSite.Models;

namespace TicketsSite.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
