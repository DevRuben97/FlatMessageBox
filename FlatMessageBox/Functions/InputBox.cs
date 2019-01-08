using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatMessageBox
{
    public class InputBox
    {
        public static string Show(IWin32Window ventana, string title , string Question, bool ShowCancelButton= false)
        {
            string resultado;
            FlatInputBox Input = new FlatInputBox();
            Input.Title.Text = title;
            Input.txtquestion.Text = Question;
            Input.btnAcept.DialogResult = DialogResult.OK;
            Input.btnCancel.DialogResult = DialogResult.Cancel;
            Input.ShowDialog(ventana);
            Input.btnCancel.Visible = (ShowCancelButton) ? true : false;
            resultado = Input.inputdata.Text;

            return resultado;
            

                
        }
    }
}
