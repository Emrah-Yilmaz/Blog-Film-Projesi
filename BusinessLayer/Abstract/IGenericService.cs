
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void AddT (T entity);
        void RemoveT (T entity);
        void Update (T entity);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T GetItem (int id);
        List<T> GetListSelected(Expression<Func<T, bool>> filter);
        List<T> GetListItem(int id);

    }
}
