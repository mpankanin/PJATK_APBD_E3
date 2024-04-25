using PJATK_APBD_E3.Models;

namespace PJATK_APBD_E3.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    void AddAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int id);
    
}