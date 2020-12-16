using System;
using Template.DataAccess.Repository.IRepository;
using Template.Models.Sql.Models;

namespace Template.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private bool _disposed = false;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            TemplateTable = new TemplateTableRepository(_db);
        }

        public ITemplateTableRepository TemplateTable { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                _db.Dispose();
                return;
            }

            _disposed = true;
        }
    }
}