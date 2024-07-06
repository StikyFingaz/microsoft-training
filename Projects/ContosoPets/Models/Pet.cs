namespace ContosoPets.Models;

public class Pet
{
    public string Species { get; set; } = "";
    public string Id { get; set; } = "ID #: ";
    public int Age { get; set; }
    public string PhysicalDescription { get; set; } = "";
    public string PersonalityDescription { get; set; } = "";
    public string Nickname { get; set; } = "";
}
