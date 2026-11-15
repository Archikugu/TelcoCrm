using Core.Domain;
using Domain.Enums;

namespace Domain.Entities;

public class ContactMedium : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public ContactMediumType ContactMediumType { get; set; }
    public string Value { get; set; }
    public bool IsPrimary { get; set; }
    public virtual Customer Customer { get; set; }

    public ContactMedium()
    {

    }

    public ContactMedium(Guid id, Guid customerId, ContactMediumType contactMediumType, string value, bool isPrimary, Customer customer)
    {
        Id = id;
        CustomerId = customerId;
        ContactMediumType = contactMediumType;
        Value = value;
        IsPrimary = isPrimary;
        Customer = customer;
    }
}
