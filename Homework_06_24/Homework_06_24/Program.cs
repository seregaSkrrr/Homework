using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum PublicationType
{
    KomosomolskayaPravda,
    Fazenda,
    MajorGrom,
    AvtoLegendsUSSR
}

class Program
{
    static void Main(string[] args)
    {
        var families = new List<Family>
        {
            new Family("Ivanov", new List<PublicationType> { PublicationType.KomosomolskayaPravda }),
            new Family("Petrov", new List<PublicationType> { PublicationType.Fazenda, PublicationType.MajorGrom }),
            new Family("Sidorov", new List<PublicationType> { PublicationType.KomosomolskayaPravda, PublicationType.AvtoLegendsUSSR }),
            new Family("Kuznetsov", new List<PublicationType> { PublicationType.Fazenda }),
            new Family("Lebedev", new List<PublicationType> { PublicationType.KomosomolskayaPravda, PublicationType.MajorGrom }),
            new Family("Golubev", new List<PublicationType> { PublicationType.AvtoLegendsUSSR })
        };

        var postalOffice = new PostalOffice(families);

        postalOffice.PublicationReceived += (sender, publication) =>
        {
            Console.WriteLine($"Received {publication} at the postal office");
        };

        postalOffice.DeliverPublication(PublicationType.KomosomolskayaPravda);
        postalOffice.DeliverPublication(PublicationType.Fazenda);
        postalOffice.DeliverPublication(PublicationType.MajorGrom);
        postalOffice.DeliverPublication(PublicationType.AvtoLegendsUSSR);
    }
}