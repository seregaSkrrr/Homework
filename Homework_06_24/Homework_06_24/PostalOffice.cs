using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PostalOffice
{
    public event EventHandler<PublicationType> PublicationReceived;

    private List<Family> families;

    public PostalOffice(List<Family> families)
    {
        this.families = families;
    }

    public void DeliverPublication(PublicationType publication)
    {
        foreach (var family in families)
        {
            if (family.Subscriptions.Contains(publication))
            {
                OnPublicationReceived(publication);
                Console.WriteLine($"Delivering {publication} to {family.Name}");
            }
        }
    }

    protected virtual void OnPublicationReceived(PublicationType publication)
    {
        PublicationReceived?.Invoke(this, publication);
    }
}
