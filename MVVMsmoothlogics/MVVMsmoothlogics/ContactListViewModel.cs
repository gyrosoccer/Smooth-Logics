using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MVVMsmoothlogics
{
    public class ContactListViewModel
    {
        private ContactDatabase _database = new ContactDatabase();
        ObservableCollection<ContactViewModel> _Contacts = new ObservableCollection<ContactViewModel>();
        private ContactViewModel _currentSelectedContact;

        public ContactListViewModel()
        {
            for (int i = 0; i < 3; ++i)
            {
                _Contacts.Add(new ContactViewModel { ContactModel = new ContactModel {ContactName = _database.GetRandomContactName, Address = _database.GetRandomContactAddress, Email = _database.GetRandomContactEmail, Phone = _database.GetRandomContactPhoneNumber }}); 
            }
        }

        void UpdateContactsExecute()
        {
            if (_Contacts == null)
                return;

            _Contacts.Add(new ContactViewModel { ContactModel = new ContactModel { ContactName = _database.GetRandomContactName, Address = _database.GetRandomContactAddress, Email = _database.GetRandomContactEmail, Phone = _database.GetRandomContactPhoneNumber } });
        }

        bool CanUpdateContactsExecute()
        {
            return true;
        }

        public ICommand UpdateContacts { get { return new RelayCommand(UpdateContactsExecute, CanUpdateContactsExecute); } }

        public ContactViewModel CurrentSelectedContact
        {
            get
            {
                return _currentSelectedContact;
            }
            set
            {
                _currentSelectedContact = value;
            }
        }

        void DeleteContactsExecute()
        {
            if (_Contacts == null)
                return;

            _Contacts.Remove(_currentSelectedContact);
        }

        bool CanDeleteContactsExecute()
        {
            return true;
        }

        public ICommand DeleteContact{ get { return new RelayCommand(DeleteContactsExecute, CanDeleteContactsExecute); } }

        public ObservableCollection<ContactViewModel> Contacts
        {
            get
            {
                return _Contacts;
            }
            set
            {
                _Contacts = value;
            }
        }


        void TextBoxFilterExecute()
        {
            if (_Contacts == null)
                return;

            _Contacts.Remove(_currentSelectedContact);
        }

        bool CanTextBoxFilterExecute()
        {
            return true;
        }
    }
}
