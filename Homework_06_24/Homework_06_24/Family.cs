using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Family
{
    public string Name { get; set; }
    public List<PublicationType> Subscriptions { get; set; }

    public Family(string name, List<PublicationType> subscriptions)
    {
        Name = name;
        Subscriptions = subscriptions;

    }
}