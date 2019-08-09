using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void save()
        {
            int[] num = { 12, 34, 56, 554, 34, 3432, 22, 54, 556, 43, 32, 44, 54, 65, 56, 885, 5, 34, 334 };
            for (int i = 0; i < num.Length; i++)
            {
                System.Threading.Thread.Sleep(100);
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {

            FlatMessageBox.FlatMessage.Show(this, "Test Message", "This is a test message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btnInputBox_Click(object sender, EventArgs e)
        {
            string mensaje = FlatMessageBox.InputBox.Show(this, "Test", "this is a test for the inputbox", false, true, "Truco").Data;
        }

        private void BtnLoading_Click(object sender, EventArgs e)
        {
            FlatMessageBox.LoadingForm loading = new FlatMessageBox.LoadingForm(save);

            loading.ShowDialog(this);
            loading.InClose = new FlatMessageBox.LoadingForm.DoClose(() =>
            {
                FlatMessageBox.FlatMessage.Show(this, "Mensaje Probado Correctamente");
            });
        }
    }
}
