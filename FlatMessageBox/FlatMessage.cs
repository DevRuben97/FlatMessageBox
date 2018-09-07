using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace FlatMessageBox
{
    public class FlatMessage
    {
        public static DialogResult Show(IWin32Window ventana, string title, string body, MessageBoxButtons botones, MessageBoxIcon iconos)
        {
            DialogResult resultado;

            FlatMessageBox mensaje = new FlatMessageBox();
           /* Form sombra = new Form(); // Fondo Negro Para diferenciar el contenido del message box.
            sombra.WindowState = FormWindowState.Maximized;
            sombra.BackColor = Color.Black;
            sombra.FormBorderStyle = FormBorderStyle.None;
            sombra.Opacity = 0.8;
            sombra.TopMost = true;
            sombra.Show();*/
            if (body.Length > 57)
            {
                body = body.Insert(body.LastIndexOf(body), "\n");
            }
            
            mensaje.Title.Text = title;
            mensaje.DataShow.Text = body;
            switch (botones) // Evaluar el boton elegido por el desarrollador
            {
                case MessageBoxButtons.YesNo:
                    mensaje.btnAcept.Text = "Si";
                    mensaje.btnCancel.Text = "No";
                    mensaje.btnAcept.DialogResult = DialogResult.Yes;
                    mensaje.btnCancel.DialogResult = DialogResult.No;
                    break;
                case MessageBoxButtons.OK:
                    mensaje.btnCancel.Text = "Ok";
                    mensaje.btnCancel.DialogResult = DialogResult.OK;
                    mensaje.btnCancel.BackColor = Color.FromArgb(0, 120, 215);
                    mensaje.btnAcept.Visible = false;
                    break;
                case MessageBoxButtons.OKCancel:
                    mensaje.btnAcept.Text = "OK";
                    mensaje.btnCancel.Text = "Cancelar";
                    mensaje.btnAcept.DialogResult = DialogResult.OK;
                    mensaje.btnCancel.DialogResult = DialogResult.Cancel;
                    break;
                default:
                    mensaje.btnAcept.Text = "Aceptar";
                    mensaje.btnCancel.Text = "Cancelar";
                    mensaje.btnAcept.DialogResult = DialogResult.OK;
                    mensaje.btnCancel.DialogResult = DialogResult.Cancel;
                    break;
            }
            switch (iconos) // Evaluar el icono seleccionado por el desarrollador y despues lanzar el cuadro de dialogo
            {
                case MessageBoxIcon.Error:
                    mensaje.IconImage.Image = Properties.Resources.Error;
                    SystemSounds.Exclamation.Play();
                    resultado = mensaje.ShowDialog(ventana);
                   // sombra.Close();
                    break;
                case MessageBoxIcon.Question:
                    mensaje.IconImage.Image = Properties.Resources.information;
                    SystemSounds.Question.Play();
                    resultado = mensaje.ShowDialog(ventana);
                    //sombra.Close();
                    break;
                case MessageBoxIcon.Information:
                    mensaje.IconImage.Image = Properties.Resources.Success;
                    SystemSounds.Asterisk.Play();
                    resultado = mensaje.ShowDialog(ventana);
                   // sombra.Close();
                    break;
                case MessageBoxIcon.Warning:
                    mensaje.IconImage.Image = Properties.Resources.Warning;
                    SystemSounds.Exclamation.Play();
                    resultado = mensaje.ShowDialog(ventana);
                    //sombra.Close();
                    break;
                default:
                    mensaje.IconImage.Image = Properties.Resources.Success;
                    SystemSounds.Asterisk.Play();
                    resultado = mensaje.ShowDialog(ventana);
                   // sombra.Close();
                    break;              
            }
            
            return resultado;

            
        }
        public static DialogResult Show(IWin32Window vantana, string Body) // Metodo creado para Ingresar solo el cuerpo del cuadro 
        {
            DialogResult resultado;
            FlatMessageBox mensaje = new FlatMessageBox();
            /*Form sombra = new Form(); //Formulario en negro para simular una sombra
            sombra.WindowState = FormWindowState.Maximized;
            sombra.BackColor = Color.Black;
            sombra.FormBorderStyle = FormBorderStyle.None;
            sombra.Opacity = 0.8;
            sombra.TopMost = true;
            sombra.Show();*/
            if (Body.Length > 57)
            {
                Body = Body.Insert(Body.LastIndexOf(Body), "\n");
            }
            mensaje.Title.Text = "Atención:";
            mensaje.DataShow.Text = Body;
            mensaje.IconImage.Image = Properties.Resources.Warning;
            mensaje.btnAcept.Visible = false;
            mensaje.btnCancel.Text = "Aceptar";
            mensaje.btnCancel.BackColor = Color.FromArgb(0, 120, 215);
            mensaje.btnCancel.DialogResult = DialogResult.OK;
            mensaje.BodyText.Width = 390;
            mensaje.BodyText.Height = 38;
            SystemSounds.Beep.Play();
            resultado = mensaje.ShowDialog(vantana);
          //  sombra.Close();

            return resultado;
        }
       
        
    }
}
