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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
