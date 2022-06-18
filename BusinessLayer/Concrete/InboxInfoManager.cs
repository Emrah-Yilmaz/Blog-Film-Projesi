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
    public class InboxInfoManager : IGenericService<InboxInfo>
    {
        private readonly IGenericDal<InboxInfo> _genericDal;

        public InboxInfoManager(IGenericDal<InboxInfo> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(InboxInfo entity)
        {
            _genericDal.Add(entity);
        }

        public InboxInfo GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<InboxInfo> GetList()
        {
            throw new NotImplementedException();
        }

        public List<InboxInfo> GetList(Expression<Func<InboxInfo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<InboxInfo> GetListItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<InboxInfo> GetListSelected(Expression<Func<InboxInfo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(InboxInfo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(InboxInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
