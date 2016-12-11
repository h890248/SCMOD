namespace ProjetoIntegrado
{
    partial class frm_crip
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
            this.btn_crip = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_crip = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_crip
            // 
            this.btn_crip.Location = new System.Drawing.Point(231, 296);
            this.btn_crip.Name = "btn_crip";
            this.btn_crip.Size = new System.Drawing.Size(190, 23);
            this.btn_crip.TabIndex = 2;
            this.btn_crip.Text = "Salvar Texto o Encriptografando";
            this.btn_crip.UseVisualStyleBackColor = true;
            this.btn_crip.Click += new System.EventHandler(this.btn_crip_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(12, 296);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(165, 23);
            this.btn_abrir.TabIndex = 3;
            this.btn_abrir.Text = "Abrir Arquivo Criptografado";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Criptografia";
            // 
            // rtb_crip
            // 
            this.rtb_crip.Location = new System.Drawing.Point(12, 49);
            this.rtb_crip.MaxLength = 140;
            this.rtb_crip.Name = "rtb_crip";
            this.rtb_crip.Size = new System.Drawing.Size(415, 241);
            this.rtb_crip.TabIndex = 26;
            this.rtb_crip.Text = "";
            // 
            // frm_crip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 333);
            this.Controls.Add(this.rtb_crip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_crip);
            this.Name = "frm_crip";
            this.Text = "frm_crip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crip;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_crip;
    }
}