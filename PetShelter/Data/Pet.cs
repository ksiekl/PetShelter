using System.ComponentModel.DataAnnotations;

namespace PetShelter.Data;

public class Pet
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual string Type { get; set; }
    public virtual string Breed { get; set; }
    public virtual int Age { get; set; }
    public virtual int UserId { get; set; }
    // public virtual User User { get; set; }
    public virtual string Picture { get; set; }
}