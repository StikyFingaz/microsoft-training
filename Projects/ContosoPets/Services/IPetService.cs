using ContosoPets.Models;

namespace ContosoPets.Services;

public interface IPetService
{
    Pet? Get(int id);
    List<Pet> GetAll();
    void Add(Pet pet);
    void Update(Pet pet);
    void Delete(int id);
}
