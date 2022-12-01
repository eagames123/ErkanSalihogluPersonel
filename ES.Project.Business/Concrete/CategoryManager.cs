using ES.Project.Business.Abstract;
using ES.Project.DataAccess.Abstract;
using ES.Project.Entity.Entities;

namespace ES.Project.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Kategori> GetAllCategories()
        {
            return _categoryDal.GetList();
        }
    }
}
