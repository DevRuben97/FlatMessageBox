namespace TestProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnInputBox = new System.Windows.Forms.Button();
            this.btnLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Mensaje";
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(16, 128);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(109, 23);
            this.btnMostar.TabIndex = 1;
            this.btnMostar.Text = "MessageBox";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnInputBox
            // 
            this.btnInputBox.Location = new System.Drawing.Point(16, 73);
            this.btnInputBox.Name = "btnInputBox";
            this.btnInputBox.Size = new System.Drawing.Size(103, 23);
            this.btnInputBox.TabIndex = 2;
            this.btnInputBox.Text = "Input Box";
            this.btnInputBox.UseVisualStyleBackColor = true;
            this.btnInputBox.Click += new System.EventHandler(this.btnInputBox_Click);
            // 
            // btnLoading
            // 
            this.btnLoading.Location = new System.Drawing.Point(16, 174);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(109, 23);
            this.btnLoading.TabIndex = 3;
            this.btnLoading.Text = "LoadingBox";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.BtnLoading_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 264);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.btnInputBox);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnInputBox;
        private System.Windows.Forms.Button btnLoading;
    }
}

