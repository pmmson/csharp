namespace WF_UgadaiN
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tBoxEnter = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblInfoOut = new System.Windows.Forms.Label();
            this.btnNewGame2 = new System.Windows.Forms.Button();
            this.btnOneTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(185, 97);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(417, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Я загадал число от 1 до 100, угадай его!";
            this.lblInfo.Visible = false;
            // 
            // tBoxEnter
            // 
            this.tBoxEnter.Location = new System.Drawing.Point(337, 158);
            this.tBoxEnter.Name = "tBoxEnter";
            this.tBoxEnter.Size = new System.Drawing.Size(100, 31);
            this.tBoxEnter.TabIndex = 1;
            this.tBoxEnter.Visible = false;
            this.tBoxEnter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TBoxEnter_MouseMove);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(307, 231);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(163, 55);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "угадать!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Visible = false;
            this.btnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(140, 31);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(211, 51);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Новая игра! - A";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblInfoOut
            // 
            this.lblInfoOut.AutoSize = true;
            this.lblInfoOut.Location = new System.Drawing.Point(351, 326);
            this.lblInfoOut.Name = "lblInfoOut";
            this.lblInfoOut.Size = new System.Drawing.Size(0, 25);
            this.lblInfoOut.TabIndex = 4;
            this.lblInfoOut.Visible = false;
            // 
            // btnNewGame2
            // 
            this.btnNewGame2.Location = new System.Drawing.Point(381, 31);
            this.btnNewGame2.Name = "btnNewGame2";
            this.btnNewGame2.Size = new System.Drawing.Size(244, 51);
            this.btnNewGame2.TabIndex = 5;
            this.btnNewGame2.Text = "Новая игра! - Б";
            this.btnNewGame2.UseVisualStyleBackColor = true;
            this.btnNewGame2.Click += new System.EventHandler(this.BtnNewGame2_Click);
            // 
            // btnOneTime
            // 
            this.btnOneTime.Location = new System.Drawing.Point(323, 232);
            this.btnOneTime.Name = "btnOneTime";
            this.btnOneTime.Size = new System.Drawing.Size(133, 54);
            this.btnOneTime.TabIndex = 6;
            this.btnOneTime.Text = "Еще раз!";
            this.btnOneTime.UseVisualStyleBackColor = true;
            this.btnOneTime.Visible = false;
            this.btnOneTime.Click += new System.EventHandler(this.BtnOneTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOneTime);
            this.Controls.Add(this.btnNewGame2);
            this.Controls.Add(this.lblInfoOut);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.tBoxEnter);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Угадай число!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tBoxEnter;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblInfoOut;
        private System.Windows.Forms.Button btnNewGame2;
        private System.Windows.Forms.Button btnOneTime;
    }
}

