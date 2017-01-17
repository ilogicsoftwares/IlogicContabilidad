using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;

namespace IlogicContabilidad.Windows
{
    public class MetroWindowBase:MetroWindow
    {
        public MetroWindowBase()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            WindowStyle = System.Windows.WindowStyle.ToolWindow;
            SetResourceReference(MetroWindow.GlowBrushProperty, "AccentColorBrush");
            ResizeMode = System.Windows.ResizeMode.CanResizeWithGrip;
          
            
        }

      
            
     
    }
}
