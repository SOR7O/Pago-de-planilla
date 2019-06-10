using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Planilla
{

    class Empleado: INotifyPropertyChanged
    {
        private string nombreEmpleado;
        private string identidad;
        private string horasTrabajadas;
        private string pagoHN;
        private string horasET;
        private string pagoHT;
        private string sueldoSinDeducciones;
        private string horasExtra;
        private string deduciones;
        private string sueldoTotal;


        public string NombreEmpleado
        {
            get
            { return nombreEmpleado; }

            set { nombreEmpleado = value; }
        }

        public string Identidad {
            get { return identidad; }
            set { identidad = value; }
        }
        public string HorasTrabajadas {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }
        public string PagoHN {
            get { return pagoHN; }
            set { pagoHN = value; }
        }
        public string HorasET {
            get { return horasET; }
            set { horasET = value; }
        }
        public string PagoHT {
            get { return pagoHT; }
            set { pagoHT = value; }
        }
        public string SueldoSinDeducciones {
            get { return sueldoSinDeducciones; }
            set {
                int S = int.Parse(PagoHT) * int.Parse(HorasTrabajadas);
                int SA = int.Parse(HorasTrabajadas) * int.Parse(PagoHN);
                int sueldoSinDeducciones = S + SA;
                sueldoSinDeducciones.ToString();
            }
        }
        public string HorasExtra {
            get { return horasExtra; }
            set {
                int horasExtra = int.Parse(HorasExtra) * int.Parse(HorasTrabajadas);
                horasExtra.ToString();
            }
        }

        public string Deduciones { 
            get
        { return deduciones; }
            set
            {
                double IHSS = 0.04;
                double RAP = 0.035;
                int S = int.Parse(PagoHT) * int.Parse(HorasTrabajadas);
                int SA = int.Parse(HorasTrabajadas) * int.Parse(PagoHN);
                int sueldoSinDeducciones = S + SA;
                double Total1 = sueldoSinDeducciones * IHSS;
                double Total2 = sueldoSinDeducciones * RAP;
                double deducciones = Total1 + Total2;
                deduciones.ToString();
            }

        }
        public string SueldoTotal {
            get {return sueldoTotal; }
            set {
                double IHSS = 0.04;
                double RAP = 0.035;
                int S = int.Parse(PagoHT) * int.Parse(HorasTrabajadas);
                int SA = int.Parse(HorasTrabajadas) * int.Parse(PagoHN);
                int sueldoSinDeducciones = S + SA;
                double Total1 = sueldoSinDeducciones * IHSS;
                double Total2 = sueldoSinDeducciones * RAP;
                double sueldoTotal= sueldoSinDeducciones - Total1 - Total2;
                sueldoTotal.ToString();
            } }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
