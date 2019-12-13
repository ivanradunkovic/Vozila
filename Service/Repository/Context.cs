using System;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Service.Repository
{
    public class ServiceContext : DbContext
    {
        public DbSet<DataDTO> Data { get; set; }

        public ServiceContext() : base("name=ServiceConnection")
        {

        }
        internal static void ExecuteSqlCommand(SqlParameter Id, SqlParameter Name, SqlParameter Abrv)
        {
            throw new NotImplementedException();
        }

        internal static void ExecuteSqlCommand(string v, SqlParameter Id, SqlParameter MakeId, SqlParameter Name, SqlParameter Abrv)
        {
            throw new NotImplementedException();
        }
    }
}