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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            if(F3.ShowDialog() == DialogResult.OK)
            {
                lstBox_Form2.Items.Add(F3.Nombre);
            }
        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBox_Form2.Items.Remove(lstBox_Form2.SelectedItem);
            
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBox_Form2.Items.Count; i++)
                lstBox_Form2.Items.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
