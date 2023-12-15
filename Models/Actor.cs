using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Pic is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(50,MinimumLength = 2,ErrorMessage ="Name must be more than 2 charactors")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }


        //Actors can have multiple actormovies

        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}
