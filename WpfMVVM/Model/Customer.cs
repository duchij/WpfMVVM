using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace WpfMVVM.Model
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _Name;

        public Customer(string pName)
        {
            this._Name = pName;
        } 

        public Customer()
        {

        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                this.onPopertyChanged("Name");
            }
        }

        protected void onPopertyChanged(string name)
        {
            //  PropertyChangedEventHandler property = this.PropertyChanged;

            PropertyChangedEventHandler property = PropertyChanged;

            if (property != null)
            {
                property.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
