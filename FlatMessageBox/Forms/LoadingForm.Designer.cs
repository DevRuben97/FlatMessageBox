namespace FlatMessageBox
{
    partial class LoadingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnMensaje = new System.Windows.Forms.Label();
            this.PictureLoad = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbnMensaje);
            this.panel1.Controls.Add(this.PictureLoad);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 137);
            this.panel1.TabIndex = 0;
            // 
            // lbnMensaje
            // 
            this.lbnMensaje.AutoSize = true;
            this.lbnMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMensaje.Location = new System.Drawing.Point(59, 87);
            this.lbnMensaje.Name = "lbnMensaje";
            this.lbnMensaje.Size = new System.Drawing.Size(239, 21);
            this.lbnMensaje.TabIndex = 3;
            this.lbnMensaje.Text = "Por favor Espere, Procesando..";
            this.lbnMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureLoad
            // 
            this.PictureLoad.Image = global::FlatMessageBox.Properties.Resources.LoadingImage;
            this.PictureLoad.Location = new System.Drawing.Point(142, 10);
            this.PictureLoad.Name = "PictureLoad";
            this.PictureLoad.Size = new System.Drawing.Size(65, 64);
            this.PictureLoad.TabIndex = 2;
            this.PictureLoad.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(366, 141);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnMensaje;
        private System.Windows.Forms.PictureBox PictureLoad;
    }
}