using System.ComponentModel.DataAnnotations;

namespace backend.Models.DTOs
{
    public class CreateContactRequest
    {
        public string name { get; set; }
        public string number { get; set; }
    }
}
