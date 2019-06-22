namespace WF_UgadaiN
{
    partial class Form2
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
            this.tBoxF2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxF2
            // 
            this.tBoxF2.Location = new System.Drawing.Point(109, 84);
            this.tBoxF2.Name = "tBoxF2";
            this.tBoxF2.Size = new System.Drawing.Size(308, 31);
            this.tBoxF2.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(211, 49);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(67, 28);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(417, 25);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "Я загадал число от 1 до 100, угадай его!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tBoxF2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ваш ответ!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxF2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo2;
    }
}