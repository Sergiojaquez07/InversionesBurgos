using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inversionesBurgos
{
   
       
    public partial class FormLink1 : Form
    {
        string Nombre, Apellido, ApellidoS, Sexo, Edad, Dirrecion, Fecha, Nacimiento,Civil, Prestamo, Image;
        int Cedula;
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormLink1_Load(object sender, EventArgs e)
        {
               
           

            llenarGrip();
        }

        Dato obj = new Dato();
        public FormLink1()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            Cedula = int.Parse(txtbuscar.Text);

            dataGridView1.DataSource = obj.Buscar(Cedula);
        }

        public void llenarGrip()
        {
            dataGridView1.DataSource = obj.LlenarGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellidos.Clear();
            txtSexo.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtNacimiento.Clear();
            txtCivil.Clear();
            txtPrestamo .Clear();
            txtbuscar.Clear();
            
        }

      
        private void btnBorrar_Click(object sender, EventArgs e)
        {
             try
            {
                Cedula = int.Parse(txtCedula.Text);

                obj.Borrar(Cedula);

                MessageBox.Show("Datos del cliente Eliminados Exitosamente...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
           llenarGrip();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cedula = int.Parse(txtCedula.Text);
                Nombre = (txtNombre.Text);
                Apellido = (txtApellido.Text);
                ApellidoS = (txtApellidos.Text);
                Sexo = (txtSexo.Text);
                Edad = (txtEdad.Text);
                Dirrecion = (txtDireccion.Text);
                Fecha = (dtmFecha.Text);
                Nacimiento = (txtNacimiento.Text);
                Civil = (txtCivil.Text);
                Prestamo = (txtPrestamo.Text);
                Image = (pbImagen.Text);


                obj.Actualizar(Cedula, Nombre, Apellido, ApellidoS, Sexo, Edad, Dirrecion, Fecha, Nacimiento, Civil, Prestamo, Image);

                MessageBox.Show("Datos del Cliente Actualizados...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            llenarGrip();
        }

         private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbImagen.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cedula = int.Parse(txtCedula.Text);
                Nombre = (txtNombre.Text);
                Apellido = (txtApellido.Text);
                ApellidoS = (txtApellidos.Text);
                Sexo = (txtSexo.Text);
                Edad = (txtEdad.Text);
                Dirrecion = (txtDireccion.Text);
                Fecha = (dtmFecha.Text);
                Nacimiento = (txtNacimiento.Text);
                Civil = (txtCivil.Text);
                Prestamo = (txtPrestamo.Text);
                Image = (pbImagen.Text);

                

                obj.Guardar(Cedula, Nombre, Apellido,ApellidoS,Sexo,Edad,Dirrecion,Fecha, Nacimiento, Civil,Prestamo,Image);

                MessageBox.Show("Datos del Cliente Guardado Exitosamente...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

            llenarGrip();
        }
    }
}
