using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IMainServiceItemsRepository
    {
        IQueryable<MainServiceItem> GetServiceItems();
        MainServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(MainServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
