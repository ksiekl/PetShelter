using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShelter.Data;

public class PetAdoption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int PetId { get; set; }
    public string UserId { get; set; }

    [Required] public string Forename { get; set; }

    [Required] public string Surname { get; set; }

    [Required] public DateTime DateOfPickup { get; set; } = DateTime.Today;

    public Status Status { get; set; }
}