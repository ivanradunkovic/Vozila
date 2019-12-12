using System.Data.Entity;
using Service.Model;

namespace Service.Repository
{
    public class ServiceContext : DbContext
    {
        public DbSet<Data> Data { get; set; }

        public ServiceContext() : base("name=ServiceConnection")
        {

        }
    }
}