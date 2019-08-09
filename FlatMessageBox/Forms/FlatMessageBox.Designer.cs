namespace FlatMessageBox
{
    partial class FlatMessageBox
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
            this.txtBodyText = new System.Windows.Forms.TextBox();
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtBodyText);
            this.panel1.Controls.Add(this.IconImage);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAcept);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 228);
            this.panel1.TabIndex = 0;
            // 
            // txtBodyText
            // 
            this.txtBodyText.BackColor = System.Drawing.Color.White;
            this.txtBodyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBodyText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBodyText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyText.Location = new System.Drawing.Point(34, 111);
            this.txtBodyText.Multiline = true;
            this.txtBodyText.Name = "txtBodyText";
            this.txtBodyText.ReadOnly = true;
            this.txtBodyText.Size = new System.Drawing.Size(376, 72);
            this.txtBodyText.TabIndex = 11;
            this.txtBodyText.Text = "This is a example text pablo ramirez eeooe comdododfdfdff";
            // 
            // IconImage
            // 
            this.IconImage.Image = global::FlatMessageBox.Properties.Resources.information;
            this.IconImage.Location = new System.Drawing.Point(185, 12);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(67, 61);
            this.IconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconImage.TabIndex = 7;
            this.IconImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(323, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAcept
            // 
            this.btnAcept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAcept.FlatAppearance.BorderSize = 0;
            this.btnAcept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnAcept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcept.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.ForeColor = System.Drawing.Color.White;
            this.btnAcept.Location = new System.Drawing.Point(19, 197);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 9;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(34, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(376, 26);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.Text = "Atencion:";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FlatMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(443, 237);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatMessageBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlatMessageBox";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox IconImage;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAcept;
        public System.Windows.Forms.TextBox txtBodyText;
        public System.Windows.Forms.TextBox txtTitle;
    }
}