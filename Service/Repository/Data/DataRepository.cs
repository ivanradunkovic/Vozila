using Service.Infrastructure.Domain;
using Service.Model.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Service.Repository.Data
{
    public class DataRepository : Repository<DataDTO>, IDataRepository
    {
        public DataRepository(DbContext context) : base(context)
        {
        }

        public Model.Data.Data Add(Model.Data.Data entity)
        {
            throw new NotImplementedException();
        }

        public Model.Data.Data Delete(Model.Data.Data entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Model.Data.Data entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Data.Data> FindBy(Expression<Func<Model.Data.Data, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void InsertWithProcedure(DataDTO podatak)
        {
            var Id = new SqlParameter("@Id", podatak.Id);
            var Name = new SqlParameter("@Name", podatak.Name);
            var Abrv = new SqlParameter("@Abrv", podatak.Abrv);

            DbContext.Database.ExecuteSqlCommand("exec dbo.InsertPodaci @Id, @Name, @Abrv",
                                                                          Id, Name, Abrv);
        }

        public void InsertWithProcedure(Model.Data.Data podatak)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Model.Data.Data> IRepository<Model.Data.Data>.FindAll()
        {
            throw new NotImplementedException();
        }
    }
}