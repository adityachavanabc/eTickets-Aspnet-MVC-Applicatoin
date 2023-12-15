using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProfilePicture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //producer can have multiple movies
        public List<Movie>Movies { get; set; }
    }
}
