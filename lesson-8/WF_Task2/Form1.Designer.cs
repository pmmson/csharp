namespace WF_Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nUD1 = new System.Windows.Forms.NumericUpDown();
            this.tBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD1
            // 
            this.nUD1.Location = new System.Drawing.Point(469, 163);
            this.nUD1.Name = "nUD1";
            this.nUD1.Size = new System.Drawing.Size(120, 31);
            this.nUD1.TabIndex = 0;
            this.nUD1.ValueChanged += new System.EventHandler(this.NUD1_ValueChanged);
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(95, 163);
            this.tBox1.Multiline = true;
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(352, 153);
            this.tBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.nUD1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD1;
        private System.Windows.Forms.TextBox tBox1;
    }
}

