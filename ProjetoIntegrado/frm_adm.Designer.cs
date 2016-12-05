namespace ProjetoIntegrado
{
    partial class frm_adm
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
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_list_bloqueado = new System.Windows.Forms.Button();
            this.btn_list_perfil = new System.Windows.Forms.Button();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cmb_alterar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_perfil = new System.Windows.Forms.ComboBox();
            this.gb_consulta = new System.Windows.Forms.GroupBox();
            this.gb_alterar = new System.Windows.Forms.GroupBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.rb_bloqueado = new System.Windows.Forms.RadioButton();
            this.rb_desbloqueado = new System.Windows.Forms.RadioButton();
            this.cmb_inc_perfil = new System.Windows.Forms.ComboBox();
            this.cb_reset_pass = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_registro = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rb_sinicial = new System.Windows.Forms.RadioButton();
            this.gb_consulta.SuspendLayout();
            this.gb_alterar.SuspendLayout();
            this.gb_registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(36, 110);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(142, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Incluir Usuario";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(9, 77);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(142, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Selecionar Registro";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_list_bloqueado
            // 
            this.btn_list_bloqueado.Location = new System.Drawing.Point(6, 32);
            this.btn_list_bloqueado.Name = "btn_list_bloqueado";
            this.btn_list_bloqueado.Size = new System.Drawing.Size(142, 23);
            this.btn_list_bloqueado.TabIndex = 2;
            this.btn_list_bloqueado.Text = "Lista de Bloqueados";
            this.btn_list_bloqueado.UseVisualStyleBackColor = true;
            this.btn_list_bloqueado.Click += new System.EventHandler(this.btn_list_bloqueado_Click);
            // 
            // btn_list_perfil
            // 
            this.btn_list_perfil.Location = new System.Drawing.Point(6, 116);
            this.btn_list_perfil.Name = "btn_list_perfil";
            this.btn_list_perfil.Size = new System.Drawing.Size(142, 23);
            this.btn_list_perfil.TabIndex = 3;
            this.btn_list_perfil.Text = "Lista por Perfil";
            this.btn_list_perfil.UseVisualStyleBackColor = true;
            this.btn_list_perfil.Click += new System.EventHandler(this.btn_list_perfil_Click);
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(74, 191);
            this.txt_rg.MaxLength = 9;
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(169, 20);
            this.txt_rg.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(50, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(74, 139);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(118, 20);
            this.txt_data.TabIndex = 17;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(74, 113);
            this.txt_senha.MaxLength = 11;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(169, 20);
            this.txt_senha.TabIndex = 16;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(74, 87);
            this.txt_nome.MaxLength = 30;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(285, 20);
            this.txt_nome.TabIndex = 15;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(74, 61);
            this.txt_ID.MaxLength = 11;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(169, 20);
            this.txt_ID.TabIndex = 14;
            // 
            // cmb_alterar
            // 
            this.cmb_alterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_alterar.FormattingEnabled = true;
            this.cmb_alterar.Location = new System.Drawing.Point(9, 50);
            this.cmb_alterar.Name = "cmb_alterar";
            this.cmb_alterar.Size = new System.Drawing.Size(142, 21);
            this.cmb_alterar.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecione o Registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Selecione o Perfil";
            // 
            // cmb_perfil
            // 
            this.cmb_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_perfil.FormattingEnabled = true;
            this.cmb_perfil.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Operador",
            "Estagiario"});
            this.cmb_perfil.Location = new System.Drawing.Point(6, 89);
            this.cmb_perfil.Name = "cmb_perfil";
            this.cmb_perfil.Size = new System.Drawing.Size(142, 21);
            this.cmb_perfil.TabIndex = 30;
            // 
            // gb_consulta
            // 
            this.gb_consulta.Controls.Add(this.btn_list_bloqueado);
            this.gb_consulta.Controls.Add(this.label8);
            this.gb_consulta.Controls.Add(this.btn_list_perfil);
            this.gb_consulta.Controls.Add(this.cmb_perfil);
            this.gb_consulta.Location = new System.Drawing.Point(27, 301);
            this.gb_consulta.Name = "gb_consulta";
            this.gb_consulta.Size = new System.Drawing.Size(179, 151);
            this.gb_consulta.TabIndex = 32;
            this.gb_consulta.TabStop = false;
            this.gb_consulta.Text = "Consultas de Registros";
            // 
            // gb_alterar
            // 
            this.gb_alterar.Controls.Add(this.label1);
            this.gb_alterar.Controls.Add(this.btn_alterar);
            this.gb_alterar.Controls.Add(this.cmb_alterar);
            this.gb_alterar.Location = new System.Drawing.Point(27, 171);
            this.gb_alterar.Name = "gb_alterar";
            this.gb_alterar.Size = new System.Drawing.Size(179, 113);
            this.gb_alterar.TabIndex = 33;
            this.gb_alterar.TabStop = false;
            this.gb_alterar.Text = "Alteraçoes de Registro";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(185, 267);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(151, 23);
            this.btn_gravar.TabIndex = 34;
            this.btn_gravar.Text = "Gravar Registro";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // rb_bloqueado
            // 
            this.rb_bloqueado.AutoSize = true;
            this.rb_bloqueado.Location = new System.Drawing.Point(74, 217);
            this.rb_bloqueado.Name = "rb_bloqueado";
            this.rb_bloqueado.Size = new System.Drawing.Size(76, 17);
            this.rb_bloqueado.TabIndex = 35;
            this.rb_bloqueado.TabStop = true;
            this.rb_bloqueado.Text = "Bloqueado";
            this.rb_bloqueado.UseVisualStyleBackColor = true;
            // 
            // rb_desbloqueado
            // 
            this.rb_desbloqueado.AutoSize = true;
            this.rb_desbloqueado.Location = new System.Drawing.Point(158, 217);
            this.rb_desbloqueado.Name = "rb_desbloqueado";
            this.rb_desbloqueado.Size = new System.Drawing.Size(94, 17);
            this.rb_desbloqueado.TabIndex = 36;
            this.rb_desbloqueado.TabStop = true;
            this.rb_desbloqueado.Text = "Desbloqueado";
            this.rb_desbloqueado.UseVisualStyleBackColor = true;
            // 
            // cmb_inc_perfil
            // 
            this.cmb_inc_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_inc_perfil.FormattingEnabled = true;
            this.cmb_inc_perfil.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Operador",
            "Estagiario"});
            this.cmb_inc_perfil.Location = new System.Drawing.Point(74, 164);
            this.cmb_inc_perfil.Name = "cmb_inc_perfil";
            this.cmb_inc_perfil.Size = new System.Drawing.Size(142, 21);
            this.cmb_inc_perfil.TabIndex = 30;
            // 
            // cb_reset_pass
            // 
            this.cb_reset_pass.AutoSize = true;
            this.cb_reset_pass.Location = new System.Drawing.Point(254, 116);
            this.cb_reset_pass.Name = "cb_reset_pass";
            this.cb_reset_pass.Size = new System.Drawing.Size(97, 17);
            this.cb_reset_pass.TabIndex = 38;
            this.cb_reset_pass.Text = "Resetar Senha";
            this.cb_reset_pass.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 37);
            this.label9.TabIndex = 39;
            this.label9.Text = "Painel do Administrador";
            // 
            // gb_registro
            // 
            this.gb_registro.Controls.Add(this.rb_sinicial);
            this.gb_registro.Controls.Add(this.btn_cancel);
            this.gb_registro.Controls.Add(this.txt_ID);
            this.gb_registro.Controls.Add(this.label6);
            this.gb_registro.Controls.Add(this.cb_reset_pass);
            this.gb_registro.Controls.Add(this.label2);
            this.gb_registro.Controls.Add(this.cmb_inc_perfil);
            this.gb_registro.Controls.Add(this.ID);
            this.gb_registro.Controls.Add(this.rb_desbloqueado);
            this.gb_registro.Controls.Add(this.label5);
            this.gb_registro.Controls.Add(this.rb_bloqueado);
            this.gb_registro.Controls.Add(this.label7);
            this.gb_registro.Controls.Add(this.btn_gravar);
            this.gb_registro.Controls.Add(this.label3);
            this.gb_registro.Controls.Add(this.label4);
            this.gb_registro.Controls.Add(this.txt_nome);
            this.gb_registro.Controls.Add(this.txt_rg);
            this.gb_registro.Controls.Add(this.txt_senha);
            this.gb_registro.Controls.Add(this.txt_data);
            this.gb_registro.Location = new System.Drawing.Point(239, 110);
            this.gb_registro.Name = "gb_registro";
            this.gb_registro.Size = new System.Drawing.Size(382, 342);
            this.gb_registro.TabIndex = 40;
            this.gb_registro.TabStop = false;
            this.gb_registro.Text = "Registro";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(104, 267);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rb_sinicial
            // 
            this.rb_sinicial.AutoSize = true;
            this.rb_sinicial.Location = new System.Drawing.Point(251, 217);
            this.rb_sinicial.Name = "rb_sinicial";
            this.rb_sinicial.Size = new System.Drawing.Size(86, 17);
            this.rb_sinicial.TabIndex = 40;
            this.rb_sinicial.TabStop = true;
            this.rb_sinicial.Text = "Senha Inicial";
            this.rb_sinicial.UseVisualStyleBackColor = true;
            // 
            // frm_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 487);
            this.Controls.Add(this.gb_registro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb_alterar);
            this.Controls.Add(this.gb_consulta);
            this.Controls.Add(this.btn_incluir);
            this.Name = "frm_adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do Administrador";
            this.Load += new System.EventHandler(this.frm_adm_Load);
            this.gb_consulta.ResumeLayout(false);
            this.gb_consulta.PerformLayout();
            this.gb_alterar.ResumeLayout(false);
            this.gb_alterar.PerformLayout();
            this.gb_registro.ResumeLayout(false);
            this.gb_registro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_list_bloqueado;
        private System.Windows.Forms.Button btn_list_perfil;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cmb_alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_perfil;
        private System.Windows.Forms.GroupBox gb_consulta;
        private System.Windows.Forms.GroupBox gb_alterar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.RadioButton rb_bloqueado;
        private System.Windows.Forms.RadioButton rb_desbloqueado;
        private System.Windows.Forms.CheckBox cb_reset_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_registro;
        public System.Windows.Forms.ComboBox cmb_inc_perfil;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rb_sinicial;
    }
}