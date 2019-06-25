namespace WF_Task4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.tBoxDist = new System.Windows.Forms.TextBox();
            this.tBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "дата тренировки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "дистанция (км)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "время (мин)";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(146, 264);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(133, 65);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "ОК";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(230, 55);
            this.tBoxData.Multiline = true;
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.Size = new System.Drawing.Size(160, 39);
            this.tBoxData.TabIndex = 4;
            // 
            // tBoxDist
            // 
            this.tBoxDist.Location = new System.Drawing.Point(230, 125);
            this.tBoxDist.Multiline = true;
            this.tBoxDist.Name = "tBoxDist";
            this.tBoxDist.Size = new System.Drawing.Size(160, 41);
            this.tBoxDist.TabIndex = 5;
            // 
            // tBoxTime
            // 
            this.tBoxTime.Location = new System.Drawing.Point(230, 194);
            this.tBoxTime.Multiline = true;
            this.tBoxTime.Name = "tBoxTime";
            this.tBoxTime.Size = new System.Drawing.Size(160, 40);
            this.tBoxTime.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.tBoxTime);
            this.Controls.Add(this.tBoxDist);
            this.Controls.Add(this.tBoxData);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tBoxData;
        private System.Windows.Forms.TextBox tBoxDist;
        private System.Windows.Forms.TextBox tBoxTime;
    }
}