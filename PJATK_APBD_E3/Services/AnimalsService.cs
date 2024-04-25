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
        string orderByValidated = ValidateOrderBy(orderBy);
        IEnumerable<Animal> animals = _animalsRepository.GetAnimals(orderByValidated);
        return animals;
    }

    public void AddAnimal(AnimalPostDto animalPostDto)
    {
        _animalsRepository.AddAnimal(animalPostDto);
    }

    public void UpdateAnimal(int id, Animal animal)
    {
        if(!_animalsRepository.AnimalIdExists(id))
        {
            throw new ArgumentException("Animal with given id does not exist");
        }
        animal.Id = id;
        _animalsRepository.UpdateAnimal(animal);
    }

    public void DeleteAnimal(int id)
    {
        _animalsRepository.DeleteAnimal(id);
    }
    
    private string ValidateOrderBy(string orderBy)
    {
        if(orderBy == null)
        {
            return "name";
        }
        if (orderBy != "name" && orderBy != "category" && orderBy != "description" && orderBy != "area")
        {
            throw new ArgumentException("Invalid orderBy parameter");
        }
        return orderBy;
    }
    
    
    
}