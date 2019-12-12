using System;
using System.Data.Entity;
using System.Data.SqlClient;
using Service.Model;

namespace Service.Repository
{
    public class ServiceContext : DbContext
    {
        public DbSet<DataDTO> Data { get; set; }

        public ServiceContext() : base("name=ServiceConnection")
        {

        }
        internal static void ExecuteSqlCommand(SqlParameter id, SqlParameter name, SqlParameter abrv)
        {
            throw new NotImplementedException();
        }
    }
}