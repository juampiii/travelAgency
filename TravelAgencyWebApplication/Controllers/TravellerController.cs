using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelAgencyWebApplication.Models;

namespace TravelAgencyWebApplication.Controllers
{
    public class TravellerController : ApiController
    {
        ///Data example
        Traveller[] travellers = new Traveller[]
        {
            new Traveller() { Id = 0, FirstName = "Paco", SurName = "Pozo", UserName = "ppozo", Password = "ppozo", CardNumber = "123456789", PhoneNumber = "6472841910", Adress = "Calle de la Piruleta 1", Points = 10 },
            new Traveller() { Id = 1, FirstName = "Dani", SurName = "Mendez", UserName = "dmendez", Password = "dmendez", CardNumber = "123456788", PhoneNumber = "6472841911", Adress = "Calle de la Piruleta 2", Points = 11 },
            new Traveller() { Id = 2, FirstName = "Manuel", SurName = "Quiroga", UserName = "mquiroga", Password = "mquiroga", CardNumber = "123456787", PhoneNumber = "6472841912", Adress = "Calle de la Piruleta 3", Points = 12 }

        };

        // GET: api/Traveller
        public IEnumerable<Traveller> Get()
        {
            return travellers;
        }

        // GET: api/Traveller/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Traveller
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Traveller/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Traveller/5
        public void Delete(int id)
        {
        }
    }
}
