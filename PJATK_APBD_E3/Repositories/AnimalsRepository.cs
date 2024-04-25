using System.Data.SqlClient;
using PJATK_APBD_E3.Models;

namespace PJATK_APBD_E3.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    
    private IConfiguration _configuration;
    
    public AnimalsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    
    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        using var con = new SqlConnection(_configuration[ConnectionStrings:DefaultConnection]);
        con.Open();
        var command = new SqlCommand("SELECT * FROM Animal ORDER BY @orderBy", con);
        command.Parameters.AddWithValue("@orderBy", orderBy);
        var reader = command.ExecuteReader();
        var animals = new List<Animal>();
        while (reader.Read())
        {
            animals.Add(new Animal(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
        }
        con.Close();
        return animals;
    }

    public void AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void UpdateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void DeleteAnimal(int id)
    {
        throw new NotImplementedException();
    }
    
}