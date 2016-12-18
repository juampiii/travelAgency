using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Infraestructure.Data.Persistence;
using TravelAgencyWebApplication.Models;

namespace TravelAgency.Infraestructure.Migrations
{
    class TravelsDBInitializer: DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            IList<Traveller> defaultTravellers = new List<Traveller>();

            defaultTravellers.Add(new Traveller() { Id = 0, FirstName = "Manuel", Surname = "Aguado", UserName = "maguado", CardNumber = "1234567890", Adress = "Algun sitio el Czech 5", Password = "maguado", PhoneNumber = "654345645", Points = 3 });
            defaultTravellers.Add(new Traveller() { Id = 1, FirstName = "Victor", Surname = "Rodríguez", UserName = "vrodriguez", CardNumber = "1234567891", Adress = "El Ejido Socio S/N", Password = "vrodriguez", PhoneNumber = "654345646", Points = 6 });
            defaultTravellers.Add(new Traveller() { Id = 2, FirstName = "Juanjo", Surname = "Ruíz", UserName = "jjruiz", CardNumber = "1234567892", Adress = "Chapultepec 67", Password = "jjruiz", PhoneNumber = "654345646", Points = 9 });

            foreach (Traveller tvl in defaultTravellers)
                context.Travellers.Add(tvl);
            IList<Travel> defaultTravels = new List<Travel>();

            defaultTravels.Add(new Travel() { Id = 0, Origin = "Málaga", DepartureTime = new DateTime(2017, 6, 16), Destination = "Wroclaw", ReturnTime = new DateTime(2017, 6, 27), Price = 288, Comments = "It's gonna be legen (wait for it) Dary, Legendary!" });
            defaultTravels.Add(new Travel() { Id = 1, Origin = "Madrid", DepartureTime = new DateTime(2018, 1, 07), Destination = "Amsterdam", ReturnTime = new DateTime(2019, 1, 08), Price = 288, Comments = "Why not?" });
            defaultTravels.Add(new Travel() { Id = 2, Origin = "Alicante", DepartureTime = new DateTime(2017, 4, 16), Destination = "Canarias", ReturnTime = new DateTime(2017, 4, 23), Price = 78, Comments = "Give me a break!" });

            foreach (Travel trv in defaultTravels)
                context.Travels.Add(trv);

            base.Seed(context);
        }
    }
}
