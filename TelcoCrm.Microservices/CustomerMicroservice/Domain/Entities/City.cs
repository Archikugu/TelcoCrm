using Core.Domain;

namespace Domain.Entities;

public class City : BaseEntity<string>
{
    public string Name { get; set; }

    public virtual ICollection<District> Districts { get; set; }
    public City()
    {
        Districts = new HashSet<District>();
    }

    public City(string id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}

