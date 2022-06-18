using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
       private readonly IGenericDal<Category> _genericDal;

        public CategoryManager(IGenericDal<Category> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Category entity)
        {
            _genericDal.Add(entity);
        }

        public Category GetItem(int id)
        {
            return _genericDal.GetItem(filter: x => x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _genericDal.GetAll();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListItem(int id)
        {
            return _genericDal.GetListSelected(x => x.CategoryId == id);
        }

        public List<Category> GetListSelected(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Category entity)
        {
            _genericDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _genericDal.Update(entity);
        }
    }
}
