using System.ComponentModel.DataAnnotations;
using TicketsSite.Data.Base;

namespace TicketsSite.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Picture is required")]
        public string PictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
