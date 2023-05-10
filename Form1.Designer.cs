namespace ТП_Лаба_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DaysSpisok = new System.Windows.Forms.ListBox();
            this.MaxSpeed_Input = new System.Windows.Forms.RichTextBox();
            this.SaveFile_Button = new System.Windows.Forms.Button();
            this.MinSpeed_Input = new System.Windows.Forms.RichTextBox();
            this.AvaragePulse_Input = new System.Windows.Forms.RichTextBox();
            this.AvarageSpeed_Input = new System.Windows.Forms.RichTextBox();
            this.Duration_Input = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChooseDate = new System.Windows.Forms.DateTimePicker();
            this.AddDay = new System.Windows.Forms.Button();
            this.ChooseType1 = new System.Windows.Forms.DomainUpDown();
            this.ChooseType2 = new System.Windows.Forms.DomainUpDown();
            this.DrawGraphic = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Distance_Input = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxSpeed_st = new System.Windows.Forms.RichTextBox();
            this.Distance_st = new System.Windows.Forms.RichTextBox();
            this.MaxDuration_st = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DaysSpisok
            // 
            this.DaysSpisok.FormattingEnabled = true;
            this.DaysSpisok.ItemHeight = 16;
            this.DaysSpisok.Location = new System.Drawing.Point(28, 33);
            this.DaysSpisok.Name = "DaysSpisok";
            this.DaysSpisok.Size = new System.Drawing.Size(215, 388);
            this.DaysSpisok.TabIndex = 0;
            this.DaysSpisok.SelectedIndexChanged += new System.EventHandler(this.DaysSpisok_SelectedIndexChanged);
            // 
            // MaxSpeed_Input
            // 
            this.MaxSpeed_Input.Location = new System.Drawing.Point(266, 81);
            this.MaxSpeed_Input.Name = "MaxSpeed_Input";
            this.MaxSpeed_Input.Size = new System.Drawing.Size(162, 32);
            this.MaxSpeed_Input.TabIndex = 1;
            this.MaxSpeed_Input.Text = "";
            // 
            // SaveFile_Button
            // 
            this.SaveFile_Button.Location = new System.Drawing.Point(266, 413);
            this.SaveFile_Button.Name = "SaveFile_Button";
            this.SaveFile_Button.Size = new System.Drawing.Size(162, 51);
            this.SaveFile_Button.TabIndex = 2;
            this.SaveFile_Button.Text = "Сохранить информацию в файл";
            this.SaveFile_Button.UseVisualStyleBackColor = true;
            // 
            // MinSpeed_Input
            // 
            this.MinSpeed_Input.Location = new System.Drawing.Point(266, 135);
            this.MinSpeed_Input.Name = "MinSpeed_Input";
            this.MinSpeed_Input.Size = new System.Drawing.Size(162, 32);
            this.MinSpeed_Input.TabIndex = 3;
            this.MinSpeed_Input.Text = "";
            // 
            // AvaragePulse_Input
            // 
            this.AvaragePulse_Input.Location = new System.Drawing.Point(266, 302);
            this.AvaragePulse_Input.Name = "AvaragePulse_Input";
            this.AvaragePulse_Input.Size = new System.Drawing.Size(162, 32);
            this.AvaragePulse_Input.TabIndex = 4;
            this.AvaragePulse_Input.Text = "";
            // 
            // AvarageSpeed_Input
            // 
            this.AvarageSpeed_Input.Location = new System.Drawing.Point(266, 194);
            this.AvarageSpeed_Input.Name = "AvarageSpeed_Input";
            this.AvarageSpeed_Input.Size = new System.Drawing.Size(162, 32);
            this.AvarageSpeed_Input.TabIndex = 5;
            this.AvarageSpeed_Input.Text = "";
            // 
            // Duration_Input
            // 
            this.Duration_Input.Location = new System.Drawing.Point(266, 245);
            this.Duration_Input.Name = "Duration_Input";
            this.Duration_Input.Size = new System.Drawing.Size(162, 32);
            this.Duration_Input.TabIndex = 6;
            this.Duration_Input.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Максимальная скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Минимальная скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Средняя скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Продолжительность в минутах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Средний пульс\r\n";
            // 
            // ChooseDate
            // 
            this.ChooseDate.Location = new System.Drawing.Point(266, 33);
            this.ChooseDate.Name = "ChooseDate";
            this.ChooseDate.Size = new System.Drawing.Size(200, 22);
            this.ChooseDate.TabIndex = 12;
            // 
            // AddDay
            // 
            this.AddDay.Location = new System.Drawing.Point(266, 384);
            this.AddDay.Name = "AddDay";
            this.AddDay.Size = new System.Drawing.Size(162, 23);
            this.AddDay.TabIndex = 13;
            this.AddDay.Text = "Добавить день";
            this.AddDay.UseVisualStyleBackColor = true;
            this.AddDay.Click += new System.EventHandler(this.AddDay_Click);
            // 
            // ChooseType1
            // 
            this.ChooseType1.Location = new System.Drawing.Point(509, 283);
            this.ChooseType1.Name = "ChooseType1";
            this.ChooseType1.Size = new System.Drawing.Size(120, 22);
            this.ChooseType1.TabIndex = 15;
            this.ChooseType1.Text = "ChooseType1";
            // 
            // ChooseType2
            // 
            this.ChooseType2.Location = new System.Drawing.Point(655, 283);
            this.ChooseType2.Name = "ChooseType2";
            this.ChooseType2.Size = new System.Drawing.Size(120, 22);
            this.ChooseType2.TabIndex = 16;
            this.ChooseType2.Text = "ChooseType2";
            // 
            // DrawGraphic
            // 
            this.DrawGraphic.Location = new System.Drawing.Point(802, 283);
            this.DrawGraphic.Name = "DrawGraphic";
            this.DrawGraphic.Size = new System.Drawing.Size(197, 23);
            this.DrawGraphic.TabIndex = 17;
            this.DrawGraphic.Text = "Отобразить график";
            this.DrawGraphic.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "График";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Статистика";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(509, 33);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(490, 230);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // Distance_Input
            // 
            this.Distance_Input.Location = new System.Drawing.Point(266, 349);
            this.Distance_Input.Name = "Distance_Input";
            this.Distance_Input.Size = new System.Drawing.Size(162, 32);
            this.Distance_Input.TabIndex = 21;
            this.Distance_Input.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Дистанция";
            // 
            // MaxSpeed_st
            // 
            this.MaxSpeed_st.Location = new System.Drawing.Point(509, 368);
            this.MaxSpeed_st.Name = "MaxSpeed_st";
            this.MaxSpeed_st.Size = new System.Drawing.Size(179, 23);
            this.MaxSpeed_st.TabIndex = 23;
            this.MaxSpeed_st.Text = "";
            // 
            // Distance_st
            // 
            this.Distance_st.Location = new System.Drawing.Point(509, 441);
            this.Distance_st.Name = "Distance_st";
            this.Distance_st.Size = new System.Drawing.Size(179, 23);
            this.Distance_st.TabIndex = 24;
            this.Distance_st.Text = "";
            // 
            // MaxDuration_st
            // 
            this.MaxDuration_st.Location = new System.Drawing.Point(754, 368);
            this.MaxDuration_st.Name = "MaxDuration_st";
            this.MaxDuration_st.Size = new System.Drawing.Size(179, 23);
            this.MaxDuration_st.TabIndex = 25;
            this.MaxDuration_st.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Максимальная скорость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(751, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Самая долгая пробежка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Колво км за выходные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 486);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MaxDuration_st);
            this.Controls.Add(this.Distance_st);
            this.Controls.Add(this.MaxSpeed_st);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Distance_Input);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DrawGraphic);
            this.Controls.Add(this.ChooseType2);
            this.Controls.Add(this.ChooseType1);
            this.Controls.Add(this.AddDay);
            this.Controls.Add(this.ChooseDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Duration_Input);
            this.Controls.Add(this.AvarageSpeed_Input);
            this.Controls.Add(this.AvaragePulse_Input);
            this.Controls.Add(this.MinSpeed_Input);
            this.Controls.Add(this.SaveFile_Button);
            this.Controls.Add(this.MaxSpeed_Input);
            this.Controls.Add(this.DaysSpisok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox DaysSpisok;
        public System.Windows.Forms.RichTextBox MaxSpeed_Input;
        public System.Windows.Forms.Button SaveFile_Button;
        public System.Windows.Forms.RichTextBox MinSpeed_Input;
        public System.Windows.Forms.RichTextBox AvaragePulse_Input;
        public System.Windows.Forms.RichTextBox AvarageSpeed_Input;
        public System.Windows.Forms.RichTextBox Duration_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ChooseDate;
        private System.Windows.Forms.Button AddDay;
        private System.Windows.Forms.DomainUpDown ChooseType1;
        private System.Windows.Forms.DomainUpDown ChooseType2;
        private System.Windows.Forms.Button DrawGraphic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.RichTextBox Distance_Input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox MaxSpeed_st;
        private System.Windows.Forms.RichTextBox Distance_st;
        private System.Windows.Forms.RichTextBox MaxDuration_st;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

