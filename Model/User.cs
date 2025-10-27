using System.ComponentModel.DataAnnotations;

namespace SureMan.Model
{
    public class User
    {
        [Key]
        public int Id;

        public string FullName;

        [Required, MaxLength(100)]
        public string Username { get; set; }
        //public string Password { get; set; }
        [Required, MaxLength(150)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string PhNo { get; set; }
    }
}
