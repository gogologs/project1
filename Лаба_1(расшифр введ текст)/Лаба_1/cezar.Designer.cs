using System.Windows.Forms;

namespace Лаба_1
{
    partial class cezar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.shifr = new System.Windows.Forms.Button();
            this.deshifr = new System.Windows.Forms.Button();
            this.rus = new System.Windows.Forms.CheckBox();
            this.eng = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itog = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(15, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(878, 233);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(12, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(881, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // shifr
            // 
            this.shifr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shifr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr.ForeColor = System.Drawing.Color.Lime;
            this.shifr.Location = new System.Drawing.Point(12, 495);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(151, 39);
            this.shifr.TabIndex = 3;
            this.shifr.Text = "Зашифровать";
            this.shifr.UseVisualStyleBackColor = true;
            this.shifr.Click += new System.EventHandler(this.shifr_Click);
            // 
            // deshifr
            // 
            this.deshifr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deshifr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deshifr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deshifr.ForeColor = System.Drawing.Color.Lime;
            this.deshifr.Location = new System.Drawing.Point(173, 495);
            this.deshifr.Name = "deshifr";
            this.deshifr.Size = new System.Drawing.Size(145, 39);
            this.deshifr.TabIndex = 4;
            this.deshifr.Text = "Расшифровать";
            this.deshifr.UseVisualStyleBackColor = false;
            this.deshifr.Click += new System.EventHandler(this.deshifr_Click);
            // 
            // rus
            // 
            this.rus.AutoSize = true;
            this.rus.Checked = true;
            this.rus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus.ForeColor = System.Drawing.Color.Lime;
            this.rus.Location = new System.Drawing.Point(15, 76);
            this.rus.Name = "rus";
            this.rus.Size = new System.Drawing.Size(93, 21);
            this.rus.TabIndex = 5;
            this.rus.Text = "русский";
            this.rus.UseVisualStyleBackColor = true;
            this.rus.CheckedChanged += new System.EventHandler(this.rus_CheckedChanged);
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng.ForeColor = System.Drawing.Color.Lime;
            this.eng.Location = new System.Drawing.Point(114, 76);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(120, 21);
            this.eng.TabIndex = 6;
            this.eng.Text = "английский";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.eng_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Lime;
            this.title.Location = new System.Drawing.Point(12, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(881, 34);
            this.title.TabIndex = 7;
            this.title.Text = "Приветствуем! Программа посвящена шифру Цезаря. Выберите язык, введите текст, цел" +
    "очисленный ключ \r\nи выберите нужную опцию.\r\n";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(9, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Только целое число!";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вводите только на выбранном языке!";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // itog
            // 
            this.itog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itog.ForeColor = System.Drawing.Color.Lime;
            this.itog.Location = new System.Drawing.Point(12, 537);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(881, 239);
            this.itog.TabIndex = 12;
            this.itog.Click += new System.EventHandler(this.itog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите ваш текст:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(337, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Не введен текст или ключ!";
            this.label5.Visible = false;
            // 
            // cezar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(938, 785);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eng);
            this.Controls.Add(this.rus);
            this.Controls.Add(this.deshifr);
            this.Controls.Add(this.shifr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "cezar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button shifr;
        private System.Windows.Forms.Button deshifr;
        private System.Windows.Forms.CheckBox rus;
        private System.Windows.Forms.CheckBox eng;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

