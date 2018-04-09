using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfMVVM.Command;
using WpfMVVM.Model;

namespace WpfMVVM.ViewModel
{
    public class CustomerViewModel 
    {
        private Customer _Customer = null;

        private ICommand _mCommand;

        private ICommand _writeCommand;
        public ICommand writeCommand
        {
            get
            {
                return _writeCommand ?? (_writeCommand=new WriteCommand(()=>writeToBox(),true));
            }
        }



        public ICommand mCommand
        {
            get
            {
                /*if (_mCommand == null)
                    _mCommand = new MyCommand(()=>MyAction(),true);*/
               return _mCommand ?? (_mCommand = new MyCommand(() => MyAction(), true));
            }
            //private set { }
            

           
        }


       // public MVVM.Customer

        public Customer Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                _Customer = value;
            }
        }

        public CustomerViewModel()
        {
           Customer = new Customer("duchij1");
            //Customer.PropertyChanged += delegate { test(); }; 
           // mCommand = new DelegateCommand(MyAction);
            //mCommand = new MyCommand();
        }

        public void saveChanges()
        {
            MessageBox.Show("Saved" + _Customer.Name);
        }

        protected void test()
        {
            Customer.Name = "fifo";
        }

        public void writeToBox()
        {
            Customer.Name2 = "00";
        }

        public void MyAction()
        {

            Customer.Name = "The button was pressed";
            //Customer.PropertyChanged += Customer_PropertyChanged("fifo", new System.ComponentModel.PropertyChangedEventHandler());
          
            //_Customer.Add
            //_Customer = new Customer("ho");
            //_Customer = new Customer("Halo");
           // MessageBox.Show("Saved" + Customer.Name);
        }

        private void Customer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }


        // public Customer

    }
}
