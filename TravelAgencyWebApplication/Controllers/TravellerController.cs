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
        [Route("api/Traveller/{id:int}")]
        public object Get(int id)
        {
            Traveller trav = travellers.FirstOrDefault<Traveller>(
                t => t.Id == id
                );
            if (trav == null)
            {
                return NotFound();
            }
            return Ok(trav);
        }

        //GET by name
        [Route("api/Traveller/{name}")]
        public object getTravellerByName(string name)
        {
            Traveller[] travellersFilterName = travellers.Where<Traveller>(
                t => t.FirstName.Contains(name) ).ToArray<Traveller>();
            //Si el campo está vacío puede dar un error
            return travellersFilterName;
        }

        // POST: api/Traveller
        public IEnumerable<Traveller> Post([FromBody]Traveller newTraveller)
        {
            List<Traveller> travellersList = travellers.ToList<Traveller>();
            newTraveller.Id = travellersList.Count;
            travellersList.Add(newTraveller);
            travellers = travellersList.ToArray<Traveller>();
            return travellersList;
        }

        // PUT: api/Traveller/5
        public IEnumerable<Traveller> Put(int id, [FromBody]Traveller newTraveller)
        {
            List<Traveller> travellersList = travellers.ToList<Traveller>();
            Traveller trav = travellers.FirstOrDefault<Traveller>(
                t => t.Id == id
                );
            if (trav == null)
                travellersList.Add(newTraveller);
            else
            {
                newTraveller.Id = trav.Id;
                travellersList.Remove(trav);
                travellersList.Add(newTraveller);
            }
            
            travellers = travellersList.ToArray<Traveller>();
            return travellersList;

        }

        // DELETE: api/Traveller/5
        public IEnumerable<Traveller> Delete(int id)
        {
            travellers = travellers.Where<Traveller>(c => c.Id != id).ToArray<Traveller>();
            return travellers;
        }
    }
}
