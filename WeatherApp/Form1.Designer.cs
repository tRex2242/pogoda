﻿
namespace WeatherApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.weather = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.averageTemp = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.windDir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(348, 462);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Icon
            // 
            this.Icon.BackColor = System.Drawing.Color.White;
            this.Icon.Location = new System.Drawing.Point(481, 12);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(100, 93);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 1;
            this.Icon.TabStop = false;
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weather.Location = new System.Drawing.Point(396, 135);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(93, 25);
            this.weather.TabIndex = 2;
            this.weather.Text = "Weather";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(393, 193);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(120, 25);
            this.description.TabIndex = 3;
            this.description.Text = "Description";
            // 
            // averageTemp
            // 
            this.averageTemp.AutoSize = true;
            this.averageTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageTemp.Location = new System.Drawing.Point(393, 232);
            this.averageTemp.Name = "averageTemp";
            this.averageTemp.Size = new System.Drawing.Size(152, 25);
            this.averageTemp.TabIndex = 4;
            this.averageTemp.Text = "Average Temp";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidity.Location = new System.Drawing.Point(393, 283);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(95, 25);
            this.humidity.TabIndex = 5;
            this.humidity.Text = "Humidity";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressure.Location = new System.Drawing.Point(396, 338);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(98, 25);
            this.pressure.TabIndex = 6;
            this.pressure.Text = "Pressure";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windSpeed.Location = new System.Drawing.Point(396, 403);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(129, 25);
            this.windSpeed.TabIndex = 7;
            this.windSpeed.Text = "Wind Speed";
            // 
            // windDir
            // 
            this.windDir.AutoSize = true;
            this.windDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windDir.Location = new System.Drawing.Point(396, 444);
            this.windDir.Name = "windDir";
            this.windDir.Size = new System.Drawing.Size(152, 25);
            this.windDir.TabIndex = 8;
            this.windDir.Text = "Wind Direction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 486);
            this.Controls.Add(this.windDir);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.averageTemp);
            this.Controls.Add(this.description);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label weather;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label averageTemp;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label windDir;
    }
}

