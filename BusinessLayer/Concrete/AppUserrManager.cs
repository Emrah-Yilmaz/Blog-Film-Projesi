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
    public class AppUserrManager : IGenericService<AppUser>
    {
        private readonly IGenericDal<AppUser> _genericDal;

        public AppUserrManager(IGenericDal<AppUser> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            return _genericDal.GetAll();
        }

        public List<AppUser> GetList(Expression<Func<AppUser, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetListItem(int id)
        {
            return _genericDal.GetListSelected(x => x.Id == id);
        }

        public List<AppUser> GetListSelected(Expression<Func<AppUser, bool>> filter)
        {
            return _genericDal.GetListSelected(filter);
        }

        public void RemoveT(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
