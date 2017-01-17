using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IlogicContabilidad.ViewModels
{
   public class ViewModelBase : INotifyPropertyChanged
    {
        public  icontabilidadEntities bd = new icontabilidadEntities(); 

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string _Validator;
        public string Validator {
            get { return _Validator; }
            set {_Validator=value ;
                NotifyPropertyChanged();
            }
        }

    }
}
