using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IlogicContabilidad.Windows
{
    /// <summary>
    /// Interaction logic for CuentaWindow.xaml
    /// </summary>
    public partial class CuentaWindow
    {
       // plancuentas cuenta = new plancuentas();
        public CuentaWindow()
        {
            InitializeComponent();

            Nexus = "plancuentas";
            Nuevo();
            SelectQuery= "new(id as ID,codigo,descripcion,tipo)";
        }

        private void MetroToolWindowBase_Activated(object sender, EventArgs e)
        {

        }
    }
}
