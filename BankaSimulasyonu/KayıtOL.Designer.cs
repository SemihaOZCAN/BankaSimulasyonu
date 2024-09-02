namespace BankaSimulasyonu
{
    partial class KayıtOL
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxSOYAD = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxhesapno = new System.Windows.Forms.MaskedTextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTEL = new System.Windows.Forms.MaskedTextBox();
            this.buttonKAYDET = new System.Windows.Forms.Button();
            this.buttonHESAPNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC KİMLİK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELEFON:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "HESAP NO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "ŞİFRE:";
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(115, 35);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(173, 28);
            this.textBoxAD.TabIndex = 1;
            // 
            // textBoxSOYAD
            // 
            this.textBoxSOYAD.Location = new System.Drawing.Point(115, 74);
            this.textBoxSOYAD.Name = "textBoxSOYAD";
            this.textBoxSOYAD.Size = new System.Drawing.Size(173, 28);
            this.textBoxSOYAD.TabIndex = 2;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(117, 112);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(171, 28);
            this.maskedTextBoxTC.TabIndex = 3;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // maskedTextBoxhesapno
            // 
            this.maskedTextBoxhesapno.Enabled = false;
            this.maskedTextBoxhesapno.Location = new System.Drawing.Point(118, 185);
            this.maskedTextBoxhesapno.Mask = "000000";
            this.maskedTextBoxhesapno.Name = "maskedTextBoxhesapno";
            this.maskedTextBoxhesapno.Size = new System.Drawing.Size(173, 28);
            this.maskedTextBoxhesapno.TabIndex = 5;
            this.maskedTextBoxhesapno.ValidatingType = typeof(int);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(117, 225);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(175, 28);
            this.textBoxsifre.TabIndex = 6;
            this.textBoxsifre.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxTEL
            // 
            this.maskedTextBoxTEL.Location = new System.Drawing.Point(118, 146);
            this.maskedTextBoxTEL.Mask = "(999) 000-0000";
            this.maskedTextBoxTEL.Name = "maskedTextBoxTEL";
            this.maskedTextBoxTEL.Size = new System.Drawing.Size(170, 28);
            this.maskedTextBoxTEL.TabIndex = 4;
            // 
            // buttonKAYDET
            // 
            this.buttonKAYDET.BackColor = System.Drawing.Color.Moccasin;
            this.buttonKAYDET.Location = new System.Drawing.Point(138, 274);
            this.buttonKAYDET.Name = "buttonKAYDET";
            this.buttonKAYDET.Size = new System.Drawing.Size(140, 42);
            this.buttonKAYDET.TabIndex = 7;
            this.buttonKAYDET.Text = "KAYDET";
            this.buttonKAYDET.UseVisualStyleBackColor = false;
            this.buttonKAYDET.Click += new System.EventHandler(this.buttonKAYDET_Click);
            // 
            // buttonHESAPNO
            // 
            this.buttonHESAPNO.Location = new System.Drawing.Point(302, 185);
            this.buttonHESAPNO.Name = "buttonHESAPNO";
            this.buttonHESAPNO.Size = new System.Drawing.Size(39, 30);
            this.buttonHESAPNO.TabIndex = 17;
            this.buttonHESAPNO.Text = "...";
            this.buttonHESAPNO.UseVisualStyleBackColor = true;
            this.buttonHESAPNO.Click += new System.EventHandler(this.buttonHESAPNO_Click);
            // 
            // KayıtOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(353, 381);
            this.Controls.Add(this.buttonHESAPNO);
            this.Controls.Add(this.buttonKAYDET);
            this.Controls.Add(this.maskedTextBoxTEL);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.maskedTextBoxhesapno);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.textBoxSOYAD);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KayıtOL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtOL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxSOYAD;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxhesapno;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTEL;
        private System.Windows.Forms.Button buttonKAYDET;
        private System.Windows.Forms.Button buttonHESAPNO;
    }
}