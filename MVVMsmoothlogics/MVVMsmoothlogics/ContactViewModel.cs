using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMsmoothlogics
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        ContactModel _Contact;
       // int _count = 0;

        public ContactViewModel()
        {

        }

        public ContactModel ContactModel
        {
            get
            {
                return _Contact;
            }
            set
            {
                _Contact = value;
            }
        }

        public string ContactName
        {
            get { return ContactModel.ContactName; }
            set 
            {
                if (ContactModel.ContactName != value)
                {
                    ContactModel.ContactName = value;
                    RaisePropertyChanged("ContactName");
                }
            }
        }

        public string ContactAddress
        {
            get { return ContactModel.Address; }
            set
            {
                if (ContactModel.Address != value)
                {
                    ContactModel.Address = value;
                    RaisePropertyChanged("Address");
                }
            }
        }

        public string ContactEmail
        {
            get { return ContactModel.Email; }
            set
            {
                if (ContactModel.Email != value)
                {
                    ContactModel.Email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }

        public string ContactPhone
        {
            get { return ContactModel.Phone; }
            set
            {
                if (ContactModel.Phone != value)
                {
                    ContactModel.Phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
