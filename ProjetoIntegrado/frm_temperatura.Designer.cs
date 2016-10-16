namespace ProjetoIntegrado
{
    partial class frm_temperatura
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
            this.radioCelsius = new System.Windows.Forms.RadioButton();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.radioFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioKelvin = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioCelsius
            // 
            this.radioCelsius.AutoSize = true;
            this.radioCelsius.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCelsius.Location = new System.Drawing.Point(16, 45);
            this.radioCelsius.Margin = new System.Windows.Forms.Padding(4);
            this.radioCelsius.Name = "radioCelsius";
            this.radioCelsius.Size = new System.Drawing.Size(78, 20);
            this.radioCelsius.TabIndex = 0;
            this.radioCelsius.TabStop = true;
            this.radioCelsius.Text = "Celsius";
            this.radioCelsius.UseVisualStyleBackColor = true;
            this.radioCelsius.CheckedChanged += new System.EventHandler(this.radioCelsius_CheckedChanged);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(16, 157);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(203, 103);
            this.lblresult.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(140, 66);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(79, 23);
            this.txtresult.TabIndex = 3;
            this.txtresult.TextChanged += new System.EventHandler(this.txtcel_TextChanged);
            // 
            // radioFahrenheit
            // 
            this.radioFahrenheit.AutoSize = true;
            this.radioFahrenheit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFahrenheit.Location = new System.Drawing.Point(16, 91);
            this.radioFahrenheit.Margin = new System.Windows.Forms.Padding(4);
            this.radioFahrenheit.Name = "radioFahrenheit";
            this.radioFahrenheit.Size = new System.Drawing.Size(105, 20);
            this.radioFahrenheit.TabIndex = 0;
            this.radioFahrenheit.TabStop = true;
            this.radioFahrenheit.Text = "Fahrenheit";
            this.radioFahrenheit.UseVisualStyleBackColor = true;
            this.radioFahrenheit.CheckedChanged += new System.EventHandler(this.radioFahrenheit_CheckedChanged);
            // 
            // radioKelvin
            // 
            this.radioKelvin.AutoSize = true;
            this.radioKelvin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKelvin.Location = new System.Drawing.Point(16, 69);
            this.radioKelvin.Margin = new System.Windows.Forms.Padding(4);
            this.radioKelvin.Name = "radioKelvin";
            this.radioKelvin.Size = new System.Drawing.Size(70, 20);
            this.radioKelvin.TabIndex = 0;
            this.radioKelvin.TabStop = true;
            this.radioKelvin.Text = "Kelvin";
            this.radioKelvin.UseVisualStyleBackColor = true;
            this.radioKelvin.CheckedChanged += new System.EventHandler(this.radioKelvin_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoIntegrado.Properties.Resources.normal;
            this.pictureBox1.Location = new System.Drawing.Point(249, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 269);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha a escala e temperatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(381, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.radioFahrenheit);
            this.Controls.Add(this.radioCelsius);
            this.Controls.Add(this.radioKelvin);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_temperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCelsius;
        private System.Windows.Forms.RadioButton radioFahrenheit;
        private System.Windows.Forms.RadioButton radioKelvin;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}