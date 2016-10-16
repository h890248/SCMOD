namespace ProjetoIntegrado
{
    partial class frm_calculadata
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
            this.dtp_cal_nascimento = new System.Windows.Forms.DateTimePicker();
            this.dtp_cal_entre_datas_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_cal_entre_datas_final = new System.Windows.Forms.DateTimePicker();
            this.rdb_cal_nascimento = new System.Windows.Forms.RadioButton();
            this.rdb_cal_entre_datas = new System.Windows.Forms.RadioButton();
            this.rdb_cal_data_futura = new System.Windows.Forms.RadioButton();
            this.rdb_cal_data_passada = new System.Windows.Forms.RadioButton();
            this.rdb_prop_data = new System.Windows.Forms.RadioButton();
            this.rdb_prop_data_other_calen = new System.Windows.Forms.RadioButton();
            this.dtp_cal_data_futura = new System.Windows.Forms.DateTimePicker();
            this.gb_somar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soma_valor = new System.Windows.Forms.TextBox();
            this.rdb_soma_semanas = new System.Windows.Forms.RadioButton();
            this.rdb_soma_meses = new System.Windows.Forms.RadioButton();
            this.rdb_soma_dias = new System.Windows.Forms.RadioButton();
            this.gb_subtrair = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sub_valor = new System.Windows.Forms.TextBox();
            this.rdb_sub_semanas = new System.Windows.Forms.RadioButton();
            this.rdb_sub_meses = new System.Windows.Forms.RadioButton();
            this.rdb_sub_dias = new System.Windows.Forms.RadioButton();
            this.dtp_cal_data_passada = new System.Windows.Forms.DateTimePicker();
            this.dtp_prop_data = new System.Windows.Forms.DateTimePicker();
            this.btn_processar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_prop_data_other_calen = new System.Windows.Forms.ComboBox();
            this.lst_resultado = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_somar.SuspendLayout();
            this.gb_subtrair.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_cal_nascimento
            // 
            this.dtp_cal_nascimento.Location = new System.Drawing.Point(32, 106);
            this.dtp_cal_nascimento.Name = "dtp_cal_nascimento";
            this.dtp_cal_nascimento.Size = new System.Drawing.Size(227, 20);
            this.dtp_cal_nascimento.TabIndex = 6;
            // 
            // dtp_cal_entre_datas_inicial
            // 
            this.dtp_cal_entre_datas_inicial.Location = new System.Drawing.Point(31, 185);
            this.dtp_cal_entre_datas_inicial.Name = "dtp_cal_entre_datas_inicial";
            this.dtp_cal_entre_datas_inicial.Size = new System.Drawing.Size(227, 20);
            this.dtp_cal_entre_datas_inicial.TabIndex = 7;
            // 
            // dtp_cal_entre_datas_final
            // 
            this.dtp_cal_entre_datas_final.Location = new System.Drawing.Point(274, 185);
            this.dtp_cal_entre_datas_final.Name = "dtp_cal_entre_datas_final";
            this.dtp_cal_entre_datas_final.Size = new System.Drawing.Size(234, 20);
            this.dtp_cal_entre_datas_final.TabIndex = 8;
            // 
            // rdb_cal_nascimento
            // 
            this.rdb_cal_nascimento.AutoSize = true;
            this.rdb_cal_nascimento.Checked = true;
            this.rdb_cal_nascimento.Location = new System.Drawing.Point(16, 83);
            this.rdb_cal_nascimento.Name = "rdb_cal_nascimento";
            this.rdb_cal_nascimento.Size = new System.Drawing.Size(119, 17);
            this.rdb_cal_nascimento.TabIndex = 9;
            this.rdb_cal_nascimento.TabStop = true;
            this.rdb_cal_nascimento.Text = "Calcula Nascimento";
            this.rdb_cal_nascimento.UseVisualStyleBackColor = true;
            this.rdb_cal_nascimento.CheckedChanged += new System.EventHandler(this.rdb_cal_nascimento_CheckedChanged);
            // 
            // rdb_cal_entre_datas
            // 
            this.rdb_cal_entre_datas.AutoSize = true;
            this.rdb_cal_entre_datas.Location = new System.Drawing.Point(16, 144);
            this.rdb_cal_entre_datas.Name = "rdb_cal_entre_datas";
            this.rdb_cal_entre_datas.Size = new System.Drawing.Size(118, 17);
            this.rdb_cal_entre_datas.TabIndex = 10;
            this.rdb_cal_entre_datas.TabStop = true;
            this.rdb_cal_entre_datas.Text = "Calcula entre Datas";
            this.rdb_cal_entre_datas.UseVisualStyleBackColor = true;
            this.rdb_cal_entre_datas.CheckedChanged += new System.EventHandler(this.rdb_cal_entre_datas_CheckedChanged);
            // 
            // rdb_cal_data_futura
            // 
            this.rdb_cal_data_futura.AutoSize = true;
            this.rdb_cal_data_futura.Location = new System.Drawing.Point(16, 233);
            this.rdb_cal_data_futura.Name = "rdb_cal_data_futura";
            this.rdb_cal_data_futura.Size = new System.Drawing.Size(119, 17);
            this.rdb_cal_data_futura.TabIndex = 11;
            this.rdb_cal_data_futura.TabStop = true;
            this.rdb_cal_data_futura.Text = "Calcula Data Futura";
            this.rdb_cal_data_futura.UseVisualStyleBackColor = true;
            this.rdb_cal_data_futura.CheckedChanged += new System.EventHandler(this.rdb_cal_data_futura_CheckedChanged);
            // 
            // rdb_cal_data_passada
            // 
            this.rdb_cal_data_passada.AutoSize = true;
            this.rdb_cal_data_passada.Location = new System.Drawing.Point(275, 233);
            this.rdb_cal_data_passada.Name = "rdb_cal_data_passada";
            this.rdb_cal_data_passada.Size = new System.Drawing.Size(130, 17);
            this.rdb_cal_data_passada.TabIndex = 12;
            this.rdb_cal_data_passada.TabStop = true;
            this.rdb_cal_data_passada.Text = "Calcula Data Passada";
            this.rdb_cal_data_passada.UseVisualStyleBackColor = true;
            this.rdb_cal_data_passada.CheckedChanged += new System.EventHandler(this.rdb_cal_data_passada_CheckedChanged);
            // 
            // rdb_prop_data
            // 
            this.rdb_prop_data.AutoSize = true;
            this.rdb_prop_data.Location = new System.Drawing.Point(16, 441);
            this.rdb_prop_data.Name = "rdb_prop_data";
            this.rdb_prop_data.Size = new System.Drawing.Size(151, 17);
            this.rdb_prop_data.TabIndex = 13;
            this.rdb_prop_data.TabStop = true;
            this.rdb_prop_data.Text = "Propriedades sobre a Data";
            this.rdb_prop_data.UseVisualStyleBackColor = true;
            this.rdb_prop_data.CheckedChanged += new System.EventHandler(this.rdb_prop_data_CheckedChanged);
            // 
            // rdb_prop_data_other_calen
            // 
            this.rdb_prop_data_other_calen.AutoSize = true;
            this.rdb_prop_data_other_calen.Location = new System.Drawing.Point(16, 512);
            this.rdb_prop_data_other_calen.Name = "rdb_prop_data_other_calen";
            this.rdb_prop_data_other_calen.Size = new System.Drawing.Size(260, 17);
            this.rdb_prop_data_other_calen.TabIndex = 14;
            this.rdb_prop_data_other_calen.TabStop = true;
            this.rdb_prop_data_other_calen.Text = "Propriedades sobre a Data em outros calendarios:";
            this.rdb_prop_data_other_calen.UseVisualStyleBackColor = true;
            this.rdb_prop_data_other_calen.CheckedChanged += new System.EventHandler(this.rdb_prop_data_other_calen_CheckedChanged);
            // 
            // dtp_cal_data_futura
            // 
            this.dtp_cal_data_futura.Location = new System.Drawing.Point(32, 256);
            this.dtp_cal_data_futura.Name = "dtp_cal_data_futura";
            this.dtp_cal_data_futura.Size = new System.Drawing.Size(227, 20);
            this.dtp_cal_data_futura.TabIndex = 15;
            // 
            // gb_somar
            // 
            this.gb_somar.Controls.Add(this.label1);
            this.gb_somar.Controls.Add(this.txt_soma_valor);
            this.gb_somar.Controls.Add(this.rdb_soma_semanas);
            this.gb_somar.Controls.Add(this.rdb_soma_meses);
            this.gb_somar.Controls.Add(this.rdb_soma_dias);
            this.gb_somar.Location = new System.Drawing.Point(32, 291);
            this.gb_somar.Name = "gb_somar";
            this.gb_somar.Size = new System.Drawing.Size(185, 135);
            this.gb_somar.TabIndex = 16;
            this.gb_somar.TabStop = false;
            this.gb_somar.Text = "Somar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor:";
            // 
            // txt_soma_valor
            // 
            this.txt_soma_valor.Location = new System.Drawing.Point(66, 101);
            this.txt_soma_valor.Name = "txt_soma_valor";
            this.txt_soma_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_soma_valor.TabIndex = 3;
            this.txt_soma_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soma_valor_KeyPress);
            // 
            // rdb_soma_semanas
            // 
            this.rdb_soma_semanas.AutoSize = true;
            this.rdb_soma_semanas.Location = new System.Drawing.Point(7, 68);
            this.rdb_soma_semanas.Name = "rdb_soma_semanas";
            this.rdb_soma_semanas.Size = new System.Drawing.Size(69, 17);
            this.rdb_soma_semanas.TabIndex = 2;
            this.rdb_soma_semanas.TabStop = true;
            this.rdb_soma_semanas.Text = "Semanas";
            this.rdb_soma_semanas.UseVisualStyleBackColor = true;
            // 
            // rdb_soma_meses
            // 
            this.rdb_soma_meses.AutoSize = true;
            this.rdb_soma_meses.Location = new System.Drawing.Point(7, 44);
            this.rdb_soma_meses.Name = "rdb_soma_meses";
            this.rdb_soma_meses.Size = new System.Drawing.Size(56, 17);
            this.rdb_soma_meses.TabIndex = 1;
            this.rdb_soma_meses.TabStop = true;
            this.rdb_soma_meses.Text = "Meses";
            this.rdb_soma_meses.UseVisualStyleBackColor = true;
            // 
            // rdb_soma_dias
            // 
            this.rdb_soma_dias.AutoSize = true;
            this.rdb_soma_dias.Checked = true;
            this.rdb_soma_dias.Location = new System.Drawing.Point(7, 20);
            this.rdb_soma_dias.Name = "rdb_soma_dias";
            this.rdb_soma_dias.Size = new System.Drawing.Size(46, 17);
            this.rdb_soma_dias.TabIndex = 0;
            this.rdb_soma_dias.TabStop = true;
            this.rdb_soma_dias.Text = "Dias";
            this.rdb_soma_dias.UseVisualStyleBackColor = true;
            // 
            // gb_subtrair
            // 
            this.gb_subtrair.Controls.Add(this.label2);
            this.gb_subtrair.Controls.Add(this.txt_sub_valor);
            this.gb_subtrair.Controls.Add(this.rdb_sub_semanas);
            this.gb_subtrair.Controls.Add(this.rdb_sub_meses);
            this.gb_subtrair.Controls.Add(this.rdb_sub_dias);
            this.gb_subtrair.Location = new System.Drawing.Point(275, 291);
            this.gb_subtrair.Name = "gb_subtrair";
            this.gb_subtrair.Size = new System.Drawing.Size(185, 135);
            this.gb_subtrair.TabIndex = 17;
            this.gb_subtrair.TabStop = false;
            this.gb_subtrair.Text = "Subtrair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // txt_sub_valor
            // 
            this.txt_sub_valor.Location = new System.Drawing.Point(66, 101);
            this.txt_sub_valor.Name = "txt_sub_valor";
            this.txt_sub_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_valor.TabIndex = 3;
            this.txt_sub_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sub_valor_KeyPress);
            // 
            // rdb_sub_semanas
            // 
            this.rdb_sub_semanas.AutoSize = true;
            this.rdb_sub_semanas.Location = new System.Drawing.Point(7, 68);
            this.rdb_sub_semanas.Name = "rdb_sub_semanas";
            this.rdb_sub_semanas.Size = new System.Drawing.Size(69, 17);
            this.rdb_sub_semanas.TabIndex = 2;
            this.rdb_sub_semanas.TabStop = true;
            this.rdb_sub_semanas.Text = "Semanas";
            this.rdb_sub_semanas.UseVisualStyleBackColor = true;
            // 
            // rdb_sub_meses
            // 
            this.rdb_sub_meses.AutoSize = true;
            this.rdb_sub_meses.Location = new System.Drawing.Point(7, 44);
            this.rdb_sub_meses.Name = "rdb_sub_meses";
            this.rdb_sub_meses.Size = new System.Drawing.Size(56, 17);
            this.rdb_sub_meses.TabIndex = 1;
            this.rdb_sub_meses.TabStop = true;
            this.rdb_sub_meses.Text = "Meses";
            this.rdb_sub_meses.UseVisualStyleBackColor = true;
            // 
            // rdb_sub_dias
            // 
            this.rdb_sub_dias.AutoSize = true;
            this.rdb_sub_dias.Checked = true;
            this.rdb_sub_dias.Location = new System.Drawing.Point(7, 20);
            this.rdb_sub_dias.Name = "rdb_sub_dias";
            this.rdb_sub_dias.Size = new System.Drawing.Size(46, 17);
            this.rdb_sub_dias.TabIndex = 0;
            this.rdb_sub_dias.TabStop = true;
            this.rdb_sub_dias.Text = "Dias";
            this.rdb_sub_dias.UseVisualStyleBackColor = true;
            // 
            // dtp_cal_data_passada
            // 
            this.dtp_cal_data_passada.Location = new System.Drawing.Point(275, 256);
            this.dtp_cal_data_passada.Name = "dtp_cal_data_passada";
            this.dtp_cal_data_passada.Size = new System.Drawing.Size(234, 20);
            this.dtp_cal_data_passada.TabIndex = 18;
            // 
            // dtp_prop_data
            // 
            this.dtp_prop_data.Location = new System.Drawing.Point(32, 464);
            this.dtp_prop_data.Name = "dtp_prop_data";
            this.dtp_prop_data.Size = new System.Drawing.Size(227, 20);
            this.dtp_prop_data.TabIndex = 19;
            // 
            // btn_processar
            // 
            this.btn_processar.Location = new System.Drawing.Point(1025, 568);
            this.btn_processar.Name = "btn_processar";
            this.btn_processar.Size = new System.Drawing.Size(75, 23);
            this.btn_processar.TabIndex = 21;
            this.btn_processar.Text = "Processar";
            this.btn_processar.UseVisualStyleBackColor = true;
            this.btn_processar.Click += new System.EventHandler(this.btn_processar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(944, 568);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 22;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Calculadora de DATAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Resultado:";
            // 
            // cmb_prop_data_other_calen
            // 
            this.cmb_prop_data_other_calen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prop_data_other_calen.FormattingEnabled = true;
            this.cmb_prop_data_other_calen.Items.AddRange(new object[] {
            "1992",
            "1993",
            "1996",
            "1997",
            "1999",
            "2001",
            "2006",
            "2010",
            "2015"});
            this.cmb_prop_data_other_calen.Location = new System.Drawing.Point(32, 535);
            this.cmb_prop_data_other_calen.Name = "cmb_prop_data_other_calen";
            this.cmb_prop_data_other_calen.Size = new System.Drawing.Size(83, 21);
            this.cmb_prop_data_other_calen.TabIndex = 26;
            this.cmb_prop_data_other_calen.TabStop = false;
            // 
            // lst_resultado
            // 
            this.lst_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_resultado.FormattingEnabled = true;
            this.lst_resultado.ItemHeight = 20;
            this.lst_resultado.Location = new System.Drawing.Point(548, 83);
            this.lst_resultado.Name = "lst_resultado";
            this.lst_resultado.Size = new System.Drawing.Size(551, 444);
            this.lst_resultado.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data Final";
            // 
            // frm_calculadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_resultado);
            this.Controls.Add(this.cmb_prop_data_other_calen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_processar);
            this.Controls.Add(this.dtp_prop_data);
            this.Controls.Add(this.dtp_cal_data_passada);
            this.Controls.Add(this.gb_subtrair);
            this.Controls.Add(this.gb_somar);
            this.Controls.Add(this.dtp_cal_data_futura);
            this.Controls.Add(this.rdb_prop_data_other_calen);
            this.Controls.Add(this.rdb_prop_data);
            this.Controls.Add(this.rdb_cal_data_passada);
            this.Controls.Add(this.rdb_cal_data_futura);
            this.Controls.Add(this.rdb_cal_entre_datas);
            this.Controls.Add(this.rdb_cal_nascimento);
            this.Controls.Add(this.dtp_cal_entre_datas_final);
            this.Controls.Add(this.dtp_cal_entre_datas_inicial);
            this.Controls.Add(this.dtp_cal_nascimento);
            this.Name = "frm_calculadata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_calculadata";
            this.gb_somar.ResumeLayout(false);
            this.gb_somar.PerformLayout();
            this.gb_subtrair.ResumeLayout(false);
            this.gb_subtrair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_cal_nascimento;
        private System.Windows.Forms.DateTimePicker dtp_cal_entre_datas_inicial;
        private System.Windows.Forms.DateTimePicker dtp_cal_entre_datas_final;
        private System.Windows.Forms.RadioButton rdb_cal_nascimento;
        private System.Windows.Forms.RadioButton rdb_cal_entre_datas;
        private System.Windows.Forms.RadioButton rdb_cal_data_futura;
        private System.Windows.Forms.RadioButton rdb_cal_data_passada;
        private System.Windows.Forms.RadioButton rdb_prop_data;
        private System.Windows.Forms.RadioButton rdb_prop_data_other_calen;
        private System.Windows.Forms.DateTimePicker dtp_cal_data_futura;
        private System.Windows.Forms.GroupBox gb_somar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soma_valor;
        private System.Windows.Forms.RadioButton rdb_soma_semanas;
        private System.Windows.Forms.RadioButton rdb_soma_meses;
        private System.Windows.Forms.RadioButton rdb_soma_dias;
        private System.Windows.Forms.GroupBox gb_subtrair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sub_valor;
        private System.Windows.Forms.RadioButton rdb_sub_semanas;
        private System.Windows.Forms.RadioButton rdb_sub_meses;
        private System.Windows.Forms.RadioButton rdb_sub_dias;
        private System.Windows.Forms.DateTimePicker dtp_cal_data_passada;
        private System.Windows.Forms.DateTimePicker dtp_prop_data;
        private System.Windows.Forms.Button btn_processar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_prop_data_other_calen;
        private System.Windows.Forms.ListBox lst_resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}