using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPachecoEtapa2
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }
        clsVehiculos objAuto;
        clsVehiculos objAvion; //Instanciamos la clase
        clsVehiculos objBarco;
        int ContadorVehiculos = 1;
        bool Barco = false;

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculos();
            objAvion = new clsVehiculos(); //Instanciamos en memoria el objeto
            objBarco = new clsVehiculos();

            objAuto.CrearAuto();
            objAvion.CrearAvion();  //Creamos el vehiculo, aun no es visible
            objBarco.CrearBarco();

        }

        private void btnAparecer_Click(object sender, EventArgs e)
        {
            switch (ContadorVehiculos) //Segun varia ContadorVehiculos cambia el vehiculo al que llamamos
            {
                case 1:
                    objAuto.CrearAuto(); //Creamos auto
                    objAuto.pctAuto.Location = new Point(100, 50); //Lugar donde aparece
                    Controls.Add(objAuto.pctAuto); //El picture box
                    ContadorVehiculos++; //Para que no vuelva a aparecer el mismo vehiculo
                    if (Barco == true) //Si hay barco, se elimina
                    {
                        objBarco.pctBarco.Dispose();
                    }
                    break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(300, 50);
                    Controls.Add(objAvion.pctAvion);
                    objAuto.pctAuto.Dispose();
                    ContadorVehiculos++;
                    break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(500, 50);
                    Controls.Add(objBarco.pctBarco);
                    objAvion.pctAvion.Dispose();
                    ContadorVehiculos = 1; //Volvemos al uno asi llamamos al auto 
                    Barco = true;  //Decimos que si hay barco asi se oculta al volver al auto
                    break;
            }
        }
    }
}
