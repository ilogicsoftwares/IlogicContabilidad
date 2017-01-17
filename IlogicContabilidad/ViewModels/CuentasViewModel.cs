using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlogicContabilidad.ViewModels
{
    class CuentasViewModel:ViewModelBase
    {
         public CuentasViewModel()
        {

        }

        private string _codigo;
        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
                NotifyPropertyChanged();
            }
        }
    }
}
