using System;
using System.Collections.Generic;
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
using System.Reflection;

namespace IlogicContabilidad.Windows
{
    /// <summary>
    /// Interaction logic for PrincipalWindow.xaml
    /// </summary>
    public partial class PrincipalWindow 
    {
     
        public PrincipalWindow()
        {
            InitializeComponent();
           
        }

        private void AbrirForm(object sender, RoutedEventArgs e)
        {
            try { 
            var asm = Assembly.GetEntryAssembly();
            var namespaces = "IlogicContabilidad.Windows.";
            var menuitem = sender as MenuItem;
            Type xwindow = asm.GetType(namespaces + menuitem.Name.ToString());
            Window w = (Window)Activator.CreateInstance(xwindow);
            w.Title = menuitem.Header.ToString();
                w.Owner = this;
                w.Show();
            }catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
      

        private void Close(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void CommandGuardar_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (MetroToolWindowBase.ActiveToolwindow==null || MetroToolWindowBase.ActiveToolwindow.SelectQuery == string.Empty || MetroToolWindowBase.ActiveToolwindow.Nexus == string.Empty  ) { return; }
            try
            {
                WinBusqueda busqueda = new WinBusqueda("Buscar", MetroToolWindowBase.ActiveToolwindow.Nexus, MetroToolWindowBase.ActiveToolwindow.SelectQuery, MetroToolWindowBase.ActiveToolwindow);
                busqueda.Owner = this;
                busqueda.ShowMaxRestoreButton = false;
                busqueda.ResizeMode = ResizeMode.NoResize;
                busqueda.ShowDialog();
            }
            catch
            {


                MessageBox.Show("No Existe Información", "Información", MessageBoxButton.OK, MessageBoxImage.Information);


            }
        }

        private void CommandGuardar_Click(object sender, RoutedEventArgs e)
        {

            MetroToolWindowBase.ActiveToolwindow.GuardarDatos();
            MetroToolWindowBase.ActiveToolwindow.Extraguardar();
            MetroToolWindowBase.ActiveToolwindow.Activate();
        }

        private void CommandNuevo_Copy_Click(object sender, RoutedEventArgs e)
        {
            MetroToolWindowBase.ActiveToolwindow.EliminarDatos();
            MetroToolWindowBase.ActiveToolwindow.Activate();
        }

        private void CommandNuevo_Click(object sender, RoutedEventArgs e)
        {
            MetroToolWindowBase.ActiveToolwindow.Nuevo();
            MetroToolWindowBase.ActiveToolwindow.Activate();
        }
    }
}
