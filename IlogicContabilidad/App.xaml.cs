using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using IlogicContabilidad.Windows;
using System.Diagnostics;

namespace IlogicContabilidad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public enum Messagetype
    {
       Guardar,Editar,Eliminar
    }
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                var mainView = new LogingWindow();
                mainView.Show();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        public static class Extensions { 
        public static MessageBoxResult MsgGuardar(Messagetype TipoMsg)
        {
            if (TipoMsg == Messagetype.Guardar)
            {
                return MessageBox.Show("Se han Guardado los datos", "Guardar", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (TipoMsg == Messagetype.Editar)
            {
                return MessageBox.Show("Se han Editado los datos", "Editar", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                return MessageBox.Show("Seguro desea eliminar los datos", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
            }
        }

    }
}
