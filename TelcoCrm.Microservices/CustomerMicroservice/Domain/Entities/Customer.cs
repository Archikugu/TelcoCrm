using Core.Domain;

namespace Domain.Entities;

public class Customer : BaseEntity<Guid>
{
    public string CustomerName { get; set; }


    public virtual ICollection<BillingAccount> BillingAccounts { get; set; }

    public Customer()
    {
        BillingAccounts = new HashSet<BillingAccount>();
    }

}
