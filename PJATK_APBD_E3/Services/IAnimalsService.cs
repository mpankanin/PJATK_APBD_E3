using PJATK_APBD_E3.Models;

namespace PJATK_APBD_E3.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    void AddAnimal(Animal animal);
    void UpdateAnimal(int id);
    void DeleteAnimal(int id);
}