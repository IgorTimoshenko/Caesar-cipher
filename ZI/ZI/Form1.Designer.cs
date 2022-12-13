namespace ZI
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
            this.label1 = new System.Windows.Forms.Label();
            this.Alph = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Crypt = new System.Windows.Forms.RichTextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите алфавит";
            // 
            // Alph
            // 
            this.Alph.Location = new System.Drawing.Point(12, 36);
            this.Alph.Name = "Alph";
            this.Alph.Size = new System.Drawing.Size(262, 76);
            this.Alph.TabIndex = 2;
            this.Alph.Text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите криптограмму";
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(304, 36);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(241, 76);
            this.Crypt.TabIndex = 4;
            this.Crypt.Text = "";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(203, 145);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(132, 46);
            this.decrypt.TabIndex = 5;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расшифровка";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(563, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 374);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Инфо:\nДанная программа дешифрует шифр\nЦезаря с шагом 1 вправо.\n\nДля проверки введ" +
    "ите криптограмму:\nрспгёслб сбтщйхспглй";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 250);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 160);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Alph);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Alph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Crypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

