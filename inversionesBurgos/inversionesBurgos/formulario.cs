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
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }
        public void AbrirformInPanel(object From_hijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            Form fh = From_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 0)
            {
                panel1.Width = 177;
            }
            else
            {
                panel1.Width = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FormLink1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FormLink2cs());
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FormLink3());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
