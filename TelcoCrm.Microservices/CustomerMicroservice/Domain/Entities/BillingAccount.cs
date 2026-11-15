using Core.Domain;
using Domain.Enums;

namespace Domain.Entities;

public class BillingAccount : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public Guid BillingAdreessId { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }
    public BillingAccountType BillingAccountType { get; set; }
    public BillingAccountStatus BillingAccountStatus { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual Address BillingAddress { get; set; }
    public BillingAccount()
    {
        
    }

    public BillingAccount(Guid id, Guid customerId, Guid billingAdreessId, string name, string number, string description, BillingAccountType billingAccountType, BillingAccountStatus billingAccountStatus)
    {
        Id = id;
        CustomerId = customerId;
        BillingAdreessId = billingAdreessId;
        Name = name;
        Number = number;
        Description = description;
        BillingAccountType = billingAccountType;
        BillingAccountStatus = billingAccountStatus;
    }
}
