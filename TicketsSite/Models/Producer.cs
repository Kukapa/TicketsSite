using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace TicketsSite.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        public string PictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
