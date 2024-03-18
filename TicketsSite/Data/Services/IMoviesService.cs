using TicketsSite.Data.Base;
using TicketsSite.Data.ViewModels;
using TicketsSite.Models;

namespace TicketsSite.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
    }
}
