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
    public partial class Form3 : Form
    {
      public string Nombre {get; set;}
      public string Apellido { get; set; }
        public Form3()
        {
            InitializeComponent();
          
        }

        private void btn_Cerrar_Form3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Form3_Click(object sender, EventArgs e)
        {
            
            Close();
            
            
        }

        private void btn_Aceptar_Form3_Click_1(object sender, EventArgs e)
        {
            Nombre = txtBox_InsertarItem_Form3.Text;
            Close();
        }
    }
}
