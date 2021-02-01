using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication
{
    class ViewModel :Person
    {
        public Person Persons { get; set;}

        private string _fullName;
        public string FullName
        {
            get
            {
                return Persons.Fname + " " + Persons.Sname;
            }

            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public RelayCommand MyCommand { get; set; }

        public ViewModel()
        {
            Persons = new Person();

            MyCommand = new RelayCommand(CanExecute,Execute);
        }


        public bool CanExecute(object o)
        {
            if(Persons.Fname!=null && Persons.Sname!= null)
            {
                return true;
            }
            return false;

        }
        
        public void Execute(object o)
        {

            FullName = Persons.Fname + " " + Persons.Sname+"354354354";

        }




    }
}
