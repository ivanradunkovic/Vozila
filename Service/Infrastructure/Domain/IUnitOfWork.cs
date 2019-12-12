using System;

namespace Service.Infrastructure.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}