using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FPalabraDePaso = new Form2();
            FPalabraDePaso.Show();
        }

        private void fORMATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
