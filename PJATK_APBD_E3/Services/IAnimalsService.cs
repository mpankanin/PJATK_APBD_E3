using PJATK_APBD_E3.Models;

namespace PJATK_APBD_E3.Services;

public interface IAnimalsService
{
    
    IEnumerable<Animal> GetAnimals(string orderBy);
    void AddAnimal(AnimalPostDto animalPostDto);
    void UpdateAnimal(int id, Animal animal);
    void DeleteAnimal(int id);
    
}