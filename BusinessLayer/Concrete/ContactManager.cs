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
    public class ContactManager : IGenericService<Contact>
    {
        private readonly IGenericDal<Contact> _genericDal;

        public ContactManager(IGenericDal<Contact> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Contact entity)
        {
            _genericDal.Add(entity);
        }

        public Contact GetItem(int id)
        {
            return _genericDal.GetItem(x => x.ContactId == id);
        }

        public List<Contact> GetList(Expression<Func<Contact, bool>> filter = null)
        {
            return _genericDal.GetList(filter); 
        }

        public List<Contact> GetListItem(int id)
        {
            return _genericDal.GetList(x => x.ContactId == id);
        }

        public List<Contact> GetListSelected(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
