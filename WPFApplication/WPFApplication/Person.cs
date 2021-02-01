using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication
{
    class Person : INotifyPropertyChanged
    {
        private string _fName;
        public string Fname
        {
            get { return _fName; }
            set { _fName = value;
                OnPropertyChanged("Fname");
            }
        }

        private string _sName;
        public string Sname
        {
            get { return _sName; }
            set
            {
                _sName = value;
                OnPropertyChanged("Sname");
            }
        }


        protected void OnPropertyChanged(string p)
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }


        }


        public event PropertyChangedEventHandler PropertyChanged;
       

    }
}
