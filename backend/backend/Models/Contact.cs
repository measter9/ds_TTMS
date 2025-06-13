using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string name { get; set; }
        [MaxLength(9)]
        public string number { get; set; }

    }
}
