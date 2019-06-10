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

namespace Planilla
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Empleado emp
        {
            get;set;
        }
        public MainWindow()
        {
            InitializeComponent();
            emp = new Empleado
            {
                NombreEmpleado="Angel",
                Identidad="1007199600519",
                HorasTrabajadas="5",
                PagoHN="100",
                HorasET="20",
                PagoHT="200",
                SueldoSinDeducciones="10",
                HorasExtra="5",
                Deduciones="5",
                SueldoTotal="1"
            };
            this.DataContext = emp;
        }
    }
}
