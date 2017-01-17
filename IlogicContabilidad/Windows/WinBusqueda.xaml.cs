using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using System.Linq.Dynamic;

namespace IlogicContabilidad.Windows
{
    /// <summary>
    /// Interaction logic for WinBusqueda.xaml
    /// </summary>
    public partial class WinBusqueda
    {
        dynamic objetoActual;
        MetroToolWindowBase DWindow { get; set; }
        public icontabilidadEntities bd = new icontabilidadEntities();
        IEnumerable<dynamic> ConsultaInicial;
        public WinBusqueda()
        {
            InitializeComponent();

        }
        public WinBusqueda(string Titulo, string objetotype, string select, MetroToolWindowBase dwindow)
        {

            InitializeComponent();

            this.Title = Titulo;

            ShowInTaskbar = false;
            WindowStyle = WindowStyle.ToolWindow;
            SetResourceReference(MetroWindow.GlowBrushProperty, "AccentColorBrush");
            ResizeMode = ResizeMode.CanResizeWithGrip;
            consultainicial(objetotype,
               select);
            DWindow = dwindow;

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            objetoActual = dataGrid.SelectedValue;


        }

        private void dataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                dynamic item = (dynamic)this.dataGrid.SelectedValue;

                DWindow.Filtro(item.ID);
                DWindow.Activate();
                DWindow.IsForSave = false;
                Close();
            }
            catch
            {

            }


            // Datos.AFuncion(PrincipalViewModel.ObjetoActual, "Filtro", _id.ToString());


        }
       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == string.Empty)
            {

                dataGrid.DataContext = ConsultaInicial.ToArray();
                count.Content = ConsultaInicial.ToArray().Count().ToString();
            }
            else
            {
                filtrarpor(comboBox.Text, textBox.Text);
            }




        }
        private void consultainicial(string objeto, string select)
        {
            IEnumerable<dynamic> z = (bd.GetType().GetProperty(objeto).GetValue(bd, null) as IEnumerable<dynamic>);
            IEnumerable<dynamic> y = z.Select(select) as IEnumerable<dynamic>;

            ConsultaInicial = y;

            dataGrid.DataContext = y.ToArray();

            count.Content = y.ToArray().Count().ToString();
            object[] campos = y.ToArray();

            comboBox.ItemsSource = campos[0].GetType().GetProperties()
                .Select(x => x.Name);


        }

        private void filtrarpor(string Campo, object valor)
        {
            if (Campo == string.Empty) { MessageBox.Show("Selecciones un Campo para Filtrar"); return; }
            if (valor.ToString() == string.Empty) { dataGrid.DataContext = ConsultaInicial.ToArray(); }
            try
            {
                IEnumerable<dynamic> x = ConsultaInicial.Where(Campo + ".Contains(@0)", valor) as IEnumerable<dynamic>;
                dataGrid.DataContext = x.ToArray();
                count.Content = x.ToArray().Count().ToString();
            }
            catch (Exception ex)
            {
                valor = Int32.Parse(valor.ToString());
                IEnumerable<dynamic> x = ConsultaInicial.Where(Campo + "==@0", valor) as IEnumerable<dynamic>;
                dataGrid.DataContext = x.ToArray();
                count.Content = x.ToArray().Count().ToString();
            }



        }



    }
}

