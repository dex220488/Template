using Template.Models.Sql.Models;

namespace Template.DataAccess.Repository.IRepository
{
    public interface ITemplateTableRepository : IRepository<TemplateTable>
    {
        void Update(TemplateTable templateTable);
    }
}