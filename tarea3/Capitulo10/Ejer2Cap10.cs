using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.tarea3.Capitulo10
{
    public partial class Ejer2Cap10 : Form
    {
        public Ejer2Cap10()
        {
            InitializeComponent();
        }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public string Padre { get; set; }
            public string Madre { get; set; }
        }



        ArrayList array = new ArrayList();

        public Estudiante[] productos = new Estudiante[30];


        public void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            PadreTextBox.Text = string.Empty;
            MadreTextBox.Text = string.Empty;
        }

        public void Agregar()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = NombreTextBox.Text;
            estudiante.Padre = PadreTextBox.Text;
            estudiante.Madre = MadreTextBox.Text;
            array.Add(productos);
            MessageBox.Show("Guardado");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }

        private void Ejer2Cap10_Load(object sender, EventArgs e)
        {

        }


    }
}
