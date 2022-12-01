using ES.Core.Concrete;
using ES.Project.Entity.Entities;
using ES.Project.DataAccess.Abstract;

namespace ES.Project.DataAccess.Concrete
{
    public class CategoryDal : GenericRepository<Kategori>, ICategoryDal
    {
    }
}
