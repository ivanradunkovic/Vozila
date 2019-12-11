using NuGet.Protocol.Core.Types;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceVozila.Repository.Data
{
    public class DataRepository : Repository<Data>, IDataRepository
    {
        private DbContext _dbContext;

        public DataRepository(DbContext context) : base(context)
        {
            _dbContext = context;
        }

        public void InsertWithProcedure(Data podatak)
        {
            var ime = new SqlParameter("@Ime", podatak.Ime);
            var prezime = new SqlParameter("@Prezime", podatak.Prezime);
            var grad = new SqlParameter("@Grad", podatak.Grad);
            var postanskiBroj = new SqlParameter("@PostanskiBroj", podatak.PostanskiBroj);
            var telefon = new SqlParameter("@Telefon", podatak.Telefon);

            _dbContext.Database.ExecuteSqlCommand("exec dbo.InsertPodaci @Ime, @Prezime, @Grad, @PostanskiBroj, @Telefon",
                                                                          ime, prezime, grad, postanskiBroj, telefon);
        }
    }
}