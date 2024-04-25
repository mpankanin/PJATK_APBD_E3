namespace PJATK_APBD_E3.Models;

public class Animal
{

    private int _id;
    private string _name;
    private string _description;
    private string _category;
    private string _area;
    
    public int Id {get => _id; set => _id = value; }
    public string Name {get => _name; set => _name = value;}
    public string Description {get => _description; set => _description = value;}
    public string Category {get => _category; set => _category = value;}
    public string Area {get => _area; set => _area = value;}
    
    public Animal(int id, string name, string description, string category, string area)
    {
        _id = id;
        _name = name;
        _description = description;
        _category = category;
        _area = area;
    }
    
}