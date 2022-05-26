using System;
using System.Windows.Forms;

namespace ProyectTryAll
{
    public partial class permisos : Form
    {
        public permisos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void permisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
