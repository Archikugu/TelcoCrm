using Core.Domain;

namespace Domain.Entities;

public class District : BaseEntity<string>
{
    public string Name { get; set; }
    public string CityId { get; set; }
    public virtual City City { get; set; }

    public virtual ICollection<Address> Addresses { get; set; }

    public District()
    {
        Addresses = new HashSet<Address>();
    }
    public District(string id, string name, string cityId) : this()
    {
        Id = id;
        Name = name;
        CityId = cityId;
    }

}

