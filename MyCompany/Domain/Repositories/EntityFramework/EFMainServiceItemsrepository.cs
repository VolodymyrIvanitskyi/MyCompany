using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFMainServiceItemsrepository : IMainServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFMainServiceItemsrepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteServiceItem(Guid id)
        {
            context.MainServiceItems.Remove(new MainServiceItem() { Id = id });
            context.SaveChanges();
        }

        public MainServiceItem GetServiceItemById(Guid id)
        {
            return context.MainServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<MainServiceItem> GetServiceItems()
        {
            return context.MainServiceItems;
        }

        public void SaveServiceItem(MainServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
