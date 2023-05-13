using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Font ft8 = new Font( lbl_texto_F4.Font.FontFamily, 8, lbl_texto_F4.Font.Style);
            lbl_texto_F4.Font = ft8;

        }


        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font ft12= new Font(lbl_texto_F4.Font.FontFamily, 12, lbl_texto_F4.Font.Style);
            lbl_texto_F4.Font = ft12;
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font ftBold = new Font(lbl_texto_F4.Font.FontFamily, lbl_texto_F4.Font.Size, FontStyle.Bold);
            lbl_texto_F4.Font = ftBold;
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fcurs = new Font(lbl_texto_F4.Font.FontFamily, lbl_texto_F4.Font.Size, FontStyle.Italic);
            lbl_texto_F4.Font = fcurs;    
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fcurs = new Font(lbl_texto_F4.Font.FontFamily, lbl_texto_F4.Font.Size, FontStyle.Underline);
            lbl_texto_F4.Font = fcurs;
        }
    }
}
