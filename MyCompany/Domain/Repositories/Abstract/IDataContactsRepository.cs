using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IDataContactsRepository
    {
        IQueryable<DataContact> GetDataContacts();
        DataContact GetDataContactById(Guid id);
        void SaveDataContacts(DataContact entity);
        void DeleteDataContact(Guid id);
    }
}
