using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Infraestructure.Migrations;
using TravelAgencyWebApplication.Models;

namespace TravelAgency.Infraestructure.Data.Persistence
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=TravelsDBConnectionString") 
        {
            Database.SetInitializer(new TravelsDBInitializer());

        }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Insurance> Insurances { get; set; }

    }
}
