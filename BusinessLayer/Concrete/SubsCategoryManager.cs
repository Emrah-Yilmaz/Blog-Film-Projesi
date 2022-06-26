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
    public class SubsCategoryManager : IGenericService<SubsCategory>
    {
        private readonly IGenericDal<SubsCategory> _genericDal;

        public SubsCategoryManager(IGenericDal<SubsCategory> genericDal)
        {
            _genericDal = genericDal;
        }
        public List<SubsCategory> GetList()
        {
            return _genericDal.GetAll();
        }
        public void AddT(SubsCategory entity)
        {
            _genericDal.Add(entity);
        }

        public SubsCategory GetItem(int id)
        {
            throw new NotImplementedException();

        }

        public List<SubsCategory> GetList(Expression<Func<SubsCategory, bool>> filter = null)
        {
            throw new NotImplementedException();

        }

        public List<SubsCategory> GetListItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubsCategory> GetListSelected(Expression<Func<SubsCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(SubsCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SubsCategory entity)
        {
            _genericDal.Update(entity);
        }
    }
}
