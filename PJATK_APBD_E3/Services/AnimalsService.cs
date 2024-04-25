using PJATK_APBD_E3.Models;
using PJATK_APBD_E3.Repositories;

namespace PJATK_APBD_E3.Services;

public class AnimalsService : IAnimalsService
{
    
    private readonly IAnimalsRepository _animalsRepository;
    
    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }
    
    
    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        IEnumerable<Animal> animals = _animalsRepository.GetAnimals(orderBy);
        return animals;
    }

    public void AddAnimal(Animal animal)
    {
        _animalsRepository.AddAnimal(animal);
    }

    public void UpdateAnimal(Animal animal)
    {
        _animalsRepository.UpdateAnimal(animal);
    }

    public void DeleteAnimal(int id)
    {
        _animalsRepository.DeleteAnimal(id);
    }
    
}