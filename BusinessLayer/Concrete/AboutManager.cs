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
    public class AboutManager : IGenericService<About>
    {
        private readonly IGenericDal<About> _genericDal;

        public AboutManager(IGenericDal<About> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(About entity)
        {
            throw new NotImplementedException();
        }

        public About GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _genericDal.GetAll();
        }

        public List<About> GetList(Expression<Func<About, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<About> GetListItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetListSelected(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(About entity)
        {
            throw new NotImplementedException();
        }

        public void Update(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
