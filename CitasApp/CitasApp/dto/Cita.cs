using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CitasApp.dto
{

    public class Cita : INotifyPropertyChanged, IDataErrorInfo
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Grupo { get; set; }
        public DateTime Fecha { get; set; }
        public String Ciudad { get; set; }
        public String Sala { get; set; }

        public string Error => string.Empty;

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            int errores = 0;
            if (e.Action == ValidationErrorEventAction.Added)
            {
                
                errores++;
                
                    
            }
            else
            {
                
                errores--;
            }
            if (errores == 0)
            {
                ButtonAceptar.IsEnabled = true;

            }
            else
            {
                ButtonAceptar.IsEnabled = false;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                        result = "Debe introducir el nombre";
                }
                if (columnName == "Apellidos")
                {
                    if (string.IsNullOrEmpty(Apellidos))
                        result = "Debe introducir el apellido";
                }
                return result;
            }
        }

        public Cita()
        {
            Grupo = "Si";
            Fecha = DateTime.Now;
            Sala = "Sala 1";
        }

        public Cita(string nombre, string apellidos, string grupo, DateTime fecha, string ciudad, string sala)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Grupo = grupo;
            Fecha = fecha;
            Ciudad = ciudad;
            Sala = sala;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

