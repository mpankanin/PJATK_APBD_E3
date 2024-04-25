namespace PJATK_APBD_E3.Models;

public class Animal
{
    
    private int _id {get ; set;}
    private string _name {get ; set;}
    private string _description {get ; set;}
    private string _category {get ; set;}
    private string _area {get ; set;}
    
    public Animal(int id, string name, string description, string category, string area)
    {
        this._id = id;
        this._name = name;
        this._description = description;
        this._category = category;
        this._area = area;
    }
    
}