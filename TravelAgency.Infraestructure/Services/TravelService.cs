using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Common.DistributedServices;
using TravelAgency.Infraestructure.Data.Persistence;

namespace TravelAgency.Infraestructure.Services
{
    public class TravelService : ITravelService
    {
        public object getTravel(int id)
        {
            using (var context = new DBContext())
            {
                var travel = context
                    .Travels
                    .Where(t => t.Id == id)
                    .SingleOrDefault();
                return travel;
            }
        }

        public object getTravels()
        {
            using (var context = new DBContext())
            {
                var travels = context
                    .Travels
                    .ToArray();
                return travels;
            }
        }
    }
}
