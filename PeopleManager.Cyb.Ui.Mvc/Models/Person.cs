using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManager.Cyb.Ui.Mvc.Models
{
    [Table(nameof(Person))]
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
