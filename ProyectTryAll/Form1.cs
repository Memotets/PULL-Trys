using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectTryAll
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F4) || e.Alt || e.Control || e.Shift || e.KeyCode == Keys.Tab)
            {
                Alerta frm = new Alerta();
                frm.ShowDialog(this);
            }
        }


        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {
            // code for initializing the panel and setting 
            // its size goes here

            PanelLogin.Location = new Point(
                this.ClientSize.Width / 2 - PanelLogin.Size.Width / 2,
                this.ClientSize.Height / 2 - PanelLogin.Size.Height / 2);
            PanelLogin.Anchor = AnchorStyles.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si se desea cerrar una subventana usar System.Windows.Forms.Application.ExitThread() o this.exit();
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open new form
            permisos permisos = new permisos();
            this.Hide();
            permisos.Show(this);

        }
    }
}
