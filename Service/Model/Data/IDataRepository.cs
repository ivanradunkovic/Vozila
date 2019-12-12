using Service.Infrastructure.Domain;

namespace Service.Model.Data
{
    public interface IDataRepository : IRepository<Data>
    {
        void InsertWithProcedure(Data podatak);
        void InsertWithProcedure(DataDTO data);
    }
}
