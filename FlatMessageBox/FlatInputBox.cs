using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatMessageBox
{
    public partial class FlatInputBox : Form
    {
        public FlatInputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputdata_Enter(object sender, EventArgs e)
        {
           if(inputdata.Text.Equals("Ingresar Texto"))
            {
                inputdata.Clear();
            }
        }

        private void inputdata_Leave(object sender, EventArgs e)
        {
            if (inputdata.Text.Equals(""))
            {
                inputdata.Text = "Ingresar Texto";
            }
        }
    }
}
