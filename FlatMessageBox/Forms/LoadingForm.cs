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
    public partial class LoadingForm : Form
    {
        /// <summary>
        /// Mostrar un mensaje de Carga del Proceso a Ejecutar.
        /// </summary>
        public string Message { get; set; }
        private Action Work { get; set; }
        public delegate void DoClose();
        public DoClose InClose { get; set; }


        public LoadingForm(Action work)
        {
            InitializeComponent();
            this.Work = work ?? throw new ArgumentNullException();
            lbnMensaje.Text = (string.IsNullOrEmpty(Message)) ? "Por favor Espere, Procesando.." : Message;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(this.Work).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            InClose?.Invoke();
        }
    }
}
