using System.Linq;
using Template.DataAccess.Repository.IRepository;
using Template.Models.Sql.Models;

namespace Template.DataAccess.Repository
{
    public class TemplateTableRepository : Repository<TemplateTable>, ITemplateTableRepository
    {
        private readonly ApplicationDbContext _db;

        public TemplateTableRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TemplateTable templateTable)
        {
            var objFromDb = _db.TemplateTable.FirstOrDefault(s => s.Id == templateTable.Id);
            if (objFromDb != null)
            {
                objFromDb.Description = templateTable.Description;
                _db.SaveChanges();
            }
        }
    }
}