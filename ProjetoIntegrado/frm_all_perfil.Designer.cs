﻿namespace ProjetoIntegrado
{
    partial class frm_all_perfil
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
            this.label3 = new System.Windows.Forms.Label();
            this.lst_resultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(5, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "Lista pelo Perfil:";
            // 
            // lst_resultado
            // 
            this.lst_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_resultado.FormattingEnabled = true;
            this.lst_resultado.ItemHeight = 20;
            this.lst_resultado.Location = new System.Drawing.Point(5, 85);
            this.lst_resultado.Name = "lst_resultado";
            this.lst_resultado.Size = new System.Drawing.Size(1017, 384);
            this.lst_resultado.TabIndex = 30;
            // 
            // frm_all_perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_resultado);
            this.Name = "frm_all_perfil";
            this.Text = "frm_all_perfil";
            this.Load += new System.EventHandler(this.frm_all_perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_resultado;
    }
}