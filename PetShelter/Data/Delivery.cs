using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShelter.Data;

public class Delivery
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int NewPetId { get; set; }

    [Required] [ValidateComplexType] public Pet NewPet { get; set; }

    public string UserId { get; set; }

    [Required] public DateTime DateOfDelivery { get; set; } = DateTime.Today;

    public Status Status { get; set; }
}