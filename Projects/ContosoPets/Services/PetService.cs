using ContosoPets.Models;

namespace ContosoPets.Services;

public class PetService : IPetService
{
    static List<Pet> PetFriends { get; }
    static int NextId = 4;

    static PetService()
    {
        PetFriends =
        [
            new()
            {
                Species = "dog",
                Id = "ID #: d1",
                Age = 2,
                PhysicalDescription =
                    "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
                PersonalityDescription =
                    "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.",
                Nickname = "lola"
            },
            new()
            {
                Species = "dog",
                Id = "ID #: d2",
                Age = 9,
                PhysicalDescription =
                    "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
                PersonalityDescription =
                    "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
                Nickname = "loki"
            },
            new()
            {
                Species = "dog",
                Id = "ID #: d2",
                Age = 9,
                PhysicalDescription =
                    "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
                PersonalityDescription =
                    "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
                Nickname = "loki"
            },
            new()
            {
                Species = "cat",
                Id = "ID #: c3",
                Age = 1,
                PhysicalDescription =
                    "small white female weighing about 8 pounds. litter box trained.",
                PersonalityDescription = "friendly",
                Nickname = "Puss"
            },
        ];
    }

    public Pet? Get(int id) =>
        PetFriends.FirstOrDefault(pet => pet.Id == $"ID #: {pet.Species[..1]}{id}");

    public List<Pet> GetAll() => PetFriends;

    public void Add(Pet pet)
    {
        pet.Id = $"ID #: {pet.Species[..1].ToLower()}{NextId++}";
        PetFriends.Add(pet);
    }

    public void Update(Pet pet)
    {
        var index = PetFriends.FindIndex(p => p.Id == pet.Id);

        if (index == -1)
            return;

        PetFriends[index] = pet;
    }

    public void Delete(int id)
    {
        var pet = Get(id);

        if (pet is null)
            return;

        PetFriends.Remove(pet);
    }
}
