namespace Pelmenium
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.PelmenTillDay = new System.Windows.Forms.TextBox();
            this.PowerPelmen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Power = new System.Windows.Forms.TextBox();
            this.massProcent = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CutterPower = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Result3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Суточная выработка пельменей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Производительность пельменного автомата:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PowerPelmen);
            this.panel1.Controls.Add(this.PelmenTillDay);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Result1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 175);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Задача 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Необходимое количество пельменных автоматов:";
            // 
            // Result1
            // 
            this.Result1.Location = new System.Drawing.Point(87, 138);
            this.Result1.Name = "Result1";
            this.Result1.ReadOnly = true;
            this.Result1.Size = new System.Drawing.Size(100, 20);
            this.Result1.TabIndex = 10;
            // 
            // PelmenTillDay
            // 
            this.PelmenTillDay.Location = new System.Drawing.Point(6, 43);
            this.PelmenTillDay.Name = "PelmenTillDay";
            this.PelmenTillDay.Size = new System.Drawing.Size(100, 20);
            this.PelmenTillDay.TabIndex = 14;
            // 
            // PowerPelmen
            // 
            this.PowerPelmen.Location = new System.Drawing.Point(6, 82);
            this.PowerPelmen.Name = "PowerPelmen";
            this.PowerPelmen.Size = new System.Drawing.Size(100, 20);
            this.PowerPelmen.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Power);
            this.panel2.Controls.Add(this.massProcent);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Result2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(288, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 175);
            this.panel2.TabIndex = 16;
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(6, 82);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(100, 20);
            this.Power.TabIndex = 15;
            // 
            // massProcent
            // 
            this.massProcent.Location = new System.Drawing.Point(6, 40);
            this.massProcent.Name = "massProcent";
            this.massProcent.Size = new System.Drawing.Size(100, 20);
            this.massProcent.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Расчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Задача 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Необходимое количество тестомесильных машин";
            // 
            // Result2
            // 
            this.Result2.Location = new System.Drawing.Point(87, 138);
            this.Result2.Name = "Result2";
            this.Result2.ReadOnly = true;
            this.Result2.Size = new System.Drawing.Size(100, 20);
            this.Result2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Массовая доля теста в готовой продукции";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Производительность тестомесильной машины";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CutterPower);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Result3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(12, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 124);
            this.panel3.TabIndex = 17;
            // 
            // CutterPower
            // 
            this.CutterPower.Location = new System.Drawing.Point(6, 40);
            this.CutterPower.Name = "CutterPower";
            this.CutterPower.Size = new System.Drawing.Size(100, 20);
            this.CutterPower.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Расчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Задача 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Необходимое количество куттеров";
            // 
            // Result3
            // 
            this.Result3.Location = new System.Drawing.Point(87, 99);
            this.Result3.Name = "Result3";
            this.Result3.ReadOnly = true;
            this.Result3.Size = new System.Drawing.Size(100, 20);
            this.Result3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Производительность куттера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PowerPelmen;
        private System.Windows.Forms.TextBox PelmenTillDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Power;
        private System.Windows.Forms.TextBox massProcent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Result2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CutterPower;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Result3;
        private System.Windows.Forms.Label label11;
    }
}

