using Core.Domain;
using Domain.Enums;

namespace Domain.Entities;

public class Address : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public AddressType AddressType { get; set; }
    public string DistrictId { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string Description { get; set; }

    public virtual District District { get; set; }
    public virtual Customer Customer { get; set; }

    public virtual ICollection<BillingAccount> BillingAccounts { get; set; }

    public Address()
    {
        BillingAccounts = new HashSet<BillingAccount>();
    }

    public Address(Guid id, Guid customerId, AddressType addressType, string districtId, string street, string houseNumber, string description)
    {
        Id = id;
        CustomerId = customerId;
        AddressType = addressType;
        DistrictId = districtId;
        Street = street;
        HouseNumber = houseNumber;
        Description = description;
    }
}

