using System.Linq.Expressions;

namespace ES.Core.Abstract
{
    public interface IGenericRepository<T>
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> GetList();

        T GetById(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
