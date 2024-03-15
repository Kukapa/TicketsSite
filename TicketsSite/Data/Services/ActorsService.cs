using Microsoft.EntityFrameworkCore;
using TicketsSite.Data.Base;
using TicketsSite.Models;

namespace TicketsSite.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) {}
    }
}