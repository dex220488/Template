using System;

namespace Template.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ITemplateTableRepository TemplateTable { get; }
    }
}