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
        public static InputResult Show(IWin32Window ventana, string title , string Question, bool ShowCancelButton=false,string DefaultValue= null)
        {
            FlatInputBox Input = new FlatInputBox();
            InputResult result = new InputResult();

            Input.Title.Text = title;
            Input.txtquestion.Text = Question;
            Input.btnAcept.DialogResult = DialogResult.OK;
            Input.btnCancel.DialogResult = DialogResult.Cancel;
            Input.btnCancel.Visible = (ShowCancelButton) ? true : false;
            Input.txtinputdata.Text = DefaultValue;
            result.Canceled = (Input.ShowDialog(ventana) == DialogResult.OK) ? false : true;
            result.Data = Input.txtinputdata.Text;

            return result;
            

                
        }
    }
    public class InputResult
    {
        public string Data { get; set; }
        public bool Canceled { get; set; }
    }
}
