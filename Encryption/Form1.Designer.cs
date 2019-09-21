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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cesarTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.keyValue = new System.Windows.Forms.NumericUpDown();
            this.vizhinerTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.cesarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).BeginInit();
            this.vizhinerTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 7);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(524, 272);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(681, 7);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(593, 272);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(544, 137);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(129, 28);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Шифрлау >>";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(544, 172);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(129, 28);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "<< Дешифрлау";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox6);
            this.groupBox1.Location = new System.Drawing.Point(11, 320);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1265, 518);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ақпарат";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox6.Location = new System.Drawing.Point(4, 39);
            this.richTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(575, 471);
            this.richTextBox6.TabIndex = 4;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cesarTab);
            this.tabControl1.Controls.Add(this.vizhinerTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 923);
            this.tabControl1.TabIndex = 5;
            // 
            // cesarTab
            // 
            this.cesarTab.BackColor = System.Drawing.SystemColors.Control;
            this.cesarTab.Controls.Add(this.label1);
            this.cesarTab.Controls.Add(this.keyValue);
            this.cesarTab.Controls.Add(this.groupBox1);
            this.cesarTab.Controls.Add(this.richTextBox1);
            this.cesarTab.Controls.Add(this.encryptButton);
            this.cesarTab.Controls.Add(this.richTextBox2);
            this.cesarTab.Controls.Add(this.decryptButton);
            this.cesarTab.Location = new System.Drawing.Point(4, 25);
            this.cesarTab.Margin = new System.Windows.Forms.Padding(4);
            this.cesarTab.Name = "cesarTab";
            this.cesarTab.Padding = new System.Windows.Forms.Padding(4);
            this.cesarTab.Size = new System.Drawing.Size(1300, 894);
            this.cesarTab.TabIndex = 0;
            this.cesarTab.Text = "Цезарь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кілт";
            // 
            // keyValue
            // 
            this.keyValue.Location = new System.Drawing.Point(544, 256);
            this.keyValue.Margin = new System.Windows.Forms.Padding(4);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(129, 22);
            this.keyValue.TabIndex = 5;
            this.keyValue.ValueChanged += new System.EventHandler(this.keyValue_ValueChanged);
            // 
            // vizhinerTab
            // 
            this.vizhinerTab.BackColor = System.Drawing.SystemColors.Control;
            this.vizhinerTab.Controls.Add(this.groupBox2);
            this.vizhinerTab.Controls.Add(this.richTextBox3);
            this.vizhinerTab.Controls.Add(this.button1);
            this.vizhinerTab.Controls.Add(this.richTextBox4);
            this.vizhinerTab.Controls.Add(this.button2);
            this.vizhinerTab.Controls.Add(this.label2);
            this.vizhinerTab.Controls.Add(this.keyText);
            this.vizhinerTab.Location = new System.Drawing.Point(4, 25);
            this.vizhinerTab.Margin = new System.Windows.Forms.Padding(4);
            this.vizhinerTab.Name = "vizhinerTab";
            this.vizhinerTab.Padding = new System.Windows.Forms.Padding(4);
            this.vizhinerTab.Size = new System.Drawing.Size(1300, 894);
            this.vizhinerTab.TabIndex = 1;
            this.vizhinerTab.Text = "Вижинер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.richTextBox8);
            this.groupBox2.Location = new System.Drawing.Point(16, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1265, 486);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ақпарат";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(735, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 471);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox8
            // 
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox8.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox8.Location = new System.Drawing.Point(4, 39);
            this.richTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(723, 471);
            this.richTextBox8.TabIndex = 4;
            this.richTextBox8.Text = resources.GetString("richTextBox8.Text");
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(16, 15);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(524, 272);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Шифрлау >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(687, 15);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(593, 272);
            this.richTextBox4.TabIndex = 13;
            this.richTextBox4.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "<< Дешифрлау";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кілт";
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(16, 327);
            this.keyText.Margin = new System.Windows.Forms.Padding(4);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(1264, 22);
            this.keyText.TabIndex = 10;
            this.keyText.TextChanged += new System.EventHandler(this.keyText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 923);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.cesarTab.ResumeLayout(false);
            this.cesarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).EndInit();
            this.vizhinerTab.ResumeLayout(false);
            this.vizhinerTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cesarTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown keyValue;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage vizhinerTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
    }
}

