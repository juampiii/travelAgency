using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Common.DistributedServices
{
    public interface ITravelService
    {
        object getTravel(int Id);

        object getTravels();
    }
}
