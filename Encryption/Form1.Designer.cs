namespace Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cesar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.keyValue = new System.Windows.Forms.NumericUpDown();
            this.vizhiner = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.cesar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).BeginInit();
            this.vizhiner.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 222);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(270, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(232, 222);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(167, 231);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Шифрлау";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(270, 231);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Дешифрлау";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox6);
            this.groupBox1.Location = new System.Drawing.Point(8, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 359);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ақпарат";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox6.Location = new System.Drawing.Point(3, 19);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(325, 218);
            this.richTextBox6.TabIndex = 4;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cesar);
            this.tabControl1.Controls.Add(this.vizhiner);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 725);
            this.tabControl1.TabIndex = 5;
            // 
            // cesar
            // 
            this.cesar.BackColor = System.Drawing.SystemColors.Control;
            this.cesar.Controls.Add(this.label1);
            this.cesar.Controls.Add(this.keyValue);
            this.cesar.Controls.Add(this.groupBox1);
            this.cesar.Controls.Add(this.richTextBox1);
            this.cesar.Controls.Add(this.encryptButton);
            this.cesar.Controls.Add(this.richTextBox2);
            this.cesar.Controls.Add(this.decryptButton);
            this.cesar.Location = new System.Drawing.Point(4, 22);
            this.cesar.Name = "cesar";
            this.cesar.Padding = new System.Windows.Forms.Padding(3);
            this.cesar.Size = new System.Drawing.Size(981, 699);
            this.cesar.TabIndex = 0;
            this.cesar.Text = "Цезарь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кілт";
            // 
            // keyValue
            // 
            this.keyValue.Location = new System.Drawing.Point(41, 234);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(120, 20);
            this.keyValue.TabIndex = 5;
            // 
            // vizhiner
            // 
            this.vizhiner.BackColor = System.Drawing.SystemColors.Control;
            this.vizhiner.Controls.Add(this.label2);
            this.vizhiner.Controls.Add(this.keyText);
            this.vizhiner.Controls.Add(this.groupBox2);
            this.vizhiner.Controls.Add(this.richTextBox3);
            this.vizhiner.Controls.Add(this.button1);
            this.vizhiner.Controls.Add(this.richTextBox4);
            this.vizhiner.Controls.Add(this.button2);
            this.vizhiner.Location = new System.Drawing.Point(4, 22);
            this.vizhiner.Name = "vizhiner";
            this.vizhiner.Padding = new System.Windows.Forms.Padding(3);
            this.vizhiner.Size = new System.Drawing.Size(981, 699);
            this.vizhiner.TabIndex = 1;
            this.vizhiner.Text = "Вижинер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кілт";
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(12, 250);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(490, 20);
            this.keyText.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.richTextBox5);
            this.groupBox2.Location = new System.Drawing.Point(8, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 227);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ақпарат";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox5.Location = new System.Drawing.Point(6, 19);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(325, 202);
            this.richTextBox5.TabIndex = 2;
            this.richTextBox5.Text = resources.GetString("richTextBox5.Text");
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(8, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(234, 222);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Шифрлау";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(270, 5);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(232, 222);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Дешифрлау";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, -54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.cesar.ResumeLayout(false);
            this.cesar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).EndInit();
            this.vizhiner.ResumeLayout(false);
            this.vizhiner.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cesar;
        private System.Windows.Forms.TabPage vizhiner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown keyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

