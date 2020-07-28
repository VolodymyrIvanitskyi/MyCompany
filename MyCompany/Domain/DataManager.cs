using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public IMainServiceItemsRepository MainServiceItems { get; set; }

        public IDataContactsRepository DataContacts {get;set;} 

        public DataManager(ITextFieldsRepository textFieldsRepository, 
            IServiceItemsRepository serviceItemsRepository, 
            IMainServiceItemsRepository mainServiceItemsRepository,
            IDataContactsRepository dataContacts)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            MainServiceItems = mainServiceItemsRepository;
            DataContacts = dataContacts;
        }
    }
}
