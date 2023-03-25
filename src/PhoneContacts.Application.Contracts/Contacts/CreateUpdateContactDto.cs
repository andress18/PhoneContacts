using System.ComponentModel.DataAnnotations;

namespace PhoneContacts.Contacts
{
    public class CreateUpdateContactDto
    {
        [Required, MaxLength(128), MinLength(3)]
        public string Name { get; set; }
        [Required, StringLength(10)]
        public string Phone { get; set; }
    }
}
