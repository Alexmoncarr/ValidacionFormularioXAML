using CitasApp.dto;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CitasApp
{
    /// <summary>
    /// Lógica de interacción para Formulario_Citas.xaml
    /// </summary>
    public partial class Formulario_Citas : Window
    {
        public Cita cita;
        private int index;

        public Formulario_Citas()
        {
            InitializeComponent();
            this.index = -1;
            cita = new Cita();
            this.DataContext = cita;
        }

        public Formulario_Citas(int index)
        {
            InitializeComponent();
            this.index = -1;
            cita = new Cita();
            this.DataContext = Citas.logica.listacitas.ElementAt(index);
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                cita = new Cita(mi_nombre.Text, mi_apellido.Text, mi_grupo.Text, (DateTime)mi_fecha.SelectedDate, mi_ciudad.Text, mi_sala.Text);
                Citas.logica.EditarCita(index, cita);
                this.Close();
            }
            else
            {
                Citas.logica.AgregarCita(cita);
            }
            cita = new Cita();
            this.DataContext = cita;
        }
        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
