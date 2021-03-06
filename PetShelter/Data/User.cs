namespace PetShelter.Data;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? SurName { get; set; }
    public List<Pet>? Pets { get; set; }
}