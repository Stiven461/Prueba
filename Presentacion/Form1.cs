using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarTexbox(params TextBox[] controles) 
        {
            foreach (var control in controles)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidarComboBox(ComboBox comb, ComboBox comn)
        {

            if (comboBox_TipoAfiliacion.SelectedItem == null)
            {
                return false;
            }

            if (comboBox_Tipo_Identificacion.SelectedItem == null)
            {
                return false;
            }


            return true;
        }
    }
}
