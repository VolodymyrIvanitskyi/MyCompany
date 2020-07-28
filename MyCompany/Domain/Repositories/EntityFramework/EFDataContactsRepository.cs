using MyCompany.Domain.Repositories.Abstract;
using MyCompany.Domain.Entities;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFDataContactsRepository : IDataContactsRepository
    {
        private readonly AppDbContext context;

        public EFDataContactsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteDataContact(Guid id)
        {
            context.DataContacts.Remove(new DataContact() { Id = id });
            context.SaveChanges();
        }

        public DataContact GetDataContactById(Guid id)
        {
            return context.DataContacts.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<DataContact> GetDataContacts()
        {
            return context.DataContacts;
        }

        public void SaveDataContacts(DataContact entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
