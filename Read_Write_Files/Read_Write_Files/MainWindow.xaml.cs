using Read_Write_Files.controlador;
using Read_Write_Files.entidades;
using Read_Write_Files.utilidades;
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

namespace Read_Write_Files
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Input_data datos_externos = new Input_data();

        Controller_input_data cid = new Controller_input_data();

        List<Input_data> list_input_data = null;

        List<String> cod_service_auto = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            Date_hour dh = new Date_hour();

            this.txtfecha.Text = dh.get_date();

            this.txthora.Text = dh.get_hour();

            Controller_input_data cid = new Controller_input_data();
            
            Controller_output_data cod = new Controller_output_data();
            
            List<Input_data> lid = cid.read_file(AppDomain.CurrentDomain.BaseDirectory + "RUTAS.txt");
             
            foreach(Input_data id in lid)
            {
                this.cod_service_auto.Add(id.codigo);
            }

            Output_data od = null;

            String codigo = "000000";

            String verificador = "6";

            String n_medidor = "0002222";

            String lectura_mes_cero = "44444444";

            String prom_consumo = "555555555";

            String lectura_actual = "6666666666";

            String consumo = "77777777777777";

            String fecha = new Date_hour().get_date();

            String hora = new Date_hour().get_hour();

            String error = "8888888";

            String observacion = "9999999";

            String nombre_foto = "1010101";

            String coordX = "1111111111";

            String CoordY = "222222222222";


            od = new Output_data(codigo, verificador, n_medidor, lectura_mes_cero, prom_consumo, lectura_actual,
                                 consumo, fecha, hora, error, observacion, nombre_foto, coordX, CoordY);
            cod.write_file(od, AppDomain.CurrentDomain.BaseDirectory);

        }




        private Input_data get_data(String selectedItem)
        {

            foreach (Input_data id in this.list_input_data)
            {
                if (id.codigo.Equals(selectedItem))
                {
                    return id;
                }
                else return new Input_data();
            }
            return new Input_data();
        }


       
    }
}
