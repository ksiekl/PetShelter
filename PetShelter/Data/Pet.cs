using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShelter.Data;

public class Pet
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] public string? Name { get; set; }

    [Required] public string? Type { get; set; }

    public string? Breed { get; set; } = "Unknown";
    public int? Age { get; set; }
    public string? UserId { get; set; }
    public string Picture { get; set; } = "Pets/PhotoNotAvailable.jpg";
    public string? Description { get; set; }
}