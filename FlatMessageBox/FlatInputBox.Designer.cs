namespace FlatMessageBox
{
    partial class FlatInputBox
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
            this.Title = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.inputdata = new System.Windows.Forms.TextBox();
            this.txtquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(12, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(50, 22);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(252, 180);
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
            this.btnAcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.Location = new System.Drawing.Point(121, 180);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 9;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = false;
            // 
            // inputdata
            // 
            this.inputdata.BackColor = System.Drawing.SystemColors.Control;
            this.inputdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputdata.ForeColor = System.Drawing.Color.Gray;
            this.inputdata.Location = new System.Drawing.Point(12, 131);
            this.inputdata.MaxLength = 100;
            this.inputdata.Multiline = true;
            this.inputdata.Name = "inputdata";
            this.inputdata.Size = new System.Drawing.Size(427, 29);
            this.inputdata.TabIndex = 11;
            this.inputdata.Text = "Ingresar Texto";
            this.inputdata.Enter += new System.EventHandler(this.inputdata_Enter);
            this.inputdata.Leave += new System.EventHandler(this.inputdata_Leave);
            // 
            // txtquestion
            // 
            this.txtquestion.AutoSize = true;
            this.txtquestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquestion.ForeColor = System.Drawing.Color.Black;
            this.txtquestion.Location = new System.Drawing.Point(13, 94);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(68, 16);
            this.txtquestion.TabIndex = 2;
            this.txtquestion.Text = "Question:";
            // 
            // FlatInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(447, 215);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.inputdata);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlatInputBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAcept;
        public System.Windows.Forms.Label txtquestion;
        public System.Windows.Forms.TextBox inputdata;
    }
}