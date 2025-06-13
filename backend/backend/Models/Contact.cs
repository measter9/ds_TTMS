using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Contact
    {
        [Required]
        [MaxLength(15)]
        public string name { get; set; }
        [MaxLength(9)]
        public string number { get; set; }

    }
}
