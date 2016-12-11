namespace ProjetoIntegrado
{
    partial class frm_inicial
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
            this.menu_s_index = new System.Windows.Forms.MenuStrip();
            this.MNescala = new System.Windows.Forms.ToolStripMenuItem();
            this.MNcalc_data = new System.Windows.Forms.ToolStripMenuItem();
            this.MNsobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MNsair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_adm = new System.Windows.Forms.Button();
            this.tsmi_criptografiaDeTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_s_index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_s_index
            // 
            this.menu_s_index.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_s_index.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNescala,
            this.tsmi_criptografiaDeTexto,
            this.MNcalc_data,
            this.MNsobre,
            this.MNsair});
            this.menu_s_index.Location = new System.Drawing.Point(0, 0);
            this.menu_s_index.Name = "menu_s_index";
            this.menu_s_index.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_s_index.Size = new System.Drawing.Size(655, 24);
            this.menu_s_index.TabIndex = 0;
            this.menu_s_index.Text = "menuStrip1";
            this.menu_s_index.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MNescala
            // 
            this.MNescala.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MNescala.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNescala.Name = "MNescala";
            this.MNescala.Size = new System.Drawing.Size(193, 20);
            this.MNescala.Text = "Escalas de temperatura";
            this.MNescala.Click += new System.EventHandler(this.MNescala_Click);
            // 
            // MNcalc_data
            // 
            this.MNcalc_data.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MNcalc_data.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.MNcalc_data.Name = "MNcalc_data";
            this.MNcalc_data.Size = new System.Drawing.Size(166, 20);
            this.MNcalc_data.Text = "Calculadora de Data";
            this.MNcalc_data.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MNcalc_data.Click += new System.EventHandler(this.MNcalc_data_Click);
            // 
            // MNsobre
            // 
            this.MNsobre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MNsobre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNsobre.Name = "MNsobre";
            this.MNsobre.Size = new System.Drawing.Size(62, 20);
            this.MNsobre.Text = "Sobre";
            this.MNsobre.Click += new System.EventHandler(this.MNsobre_Click);
            // 
            // MNsair
            // 
            this.MNsair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MNsair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNsair.Name = "MNsair";
            this.MNsair.Size = new System.Drawing.Size(48, 20);
            this.MNsair.Text = "Sair";
            this.MNsair.Click += new System.EventHandler(this.MNsair_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(94, 38);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(220, 21);
            this.txt_user.TabIndex = 2;
            this.txt_user.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(94, 65);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(220, 21);
            this.txt_pass.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(218, 92);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(96, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::ProjetoIntegrado.Properties.Resources.logo1;
            this.pic_logo.Location = new System.Drawing.Point(277, 61);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(134, 105);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.txt_user);
            this.gb_login.Controls.Add(this.label1);
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Controls.Add(this.txt_pass);
            this.gb_login.Location = new System.Drawing.Point(167, 195);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(334, 168);
            this.gb_login.TabIndex = 6;
            this.gb_login.TabStop = false;
            // 
            // btn_perfil
            // 
            this.btn_perfil.Location = new System.Drawing.Point(264, 257);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(167, 23);
            this.btn_perfil.TabIndex = 10;
            this.btn_perfil.Text = "Meu Perfil Completo";
            this.btn_perfil.UseVisualStyleBackColor = true;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_adm
            // 
            this.btn_adm.Location = new System.Drawing.Point(264, 228);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(167, 23);
            this.btn_adm.TabIndex = 11;
            this.btn_adm.Text = "Painel do Administrador";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.btn_adm_Click);
            // 
            // tsmi_criptografiaDeTexto
            // 
            this.tsmi_criptografiaDeTexto.BackColor = System.Drawing.SystemColors.Control;
            this.tsmi_criptografiaDeTexto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsmi_criptografiaDeTexto.Name = "tsmi_criptografiaDeTexto";
            this.tsmi_criptografiaDeTexto.Size = new System.Drawing.Size(173, 20);
            this.tsmi_criptografiaDeTexto.Text = "Criptografia de Texto";
            this.tsmi_criptografiaDeTexto.Click += new System.EventHandler(this.tsmi_criptografiaDeTexto_Click);
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 408);
            this.Controls.Add(this.btn_adm);
            this.Controls.Add(this.btn_perfil);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.menu_s_index);
            this.Controls.Add(this.gb_login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_s_index;
            this.MaximizeBox = false;
            this.Name = "frm_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCMOD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_s_index.ResumeLayout(false);
            this.menu_s_index.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_s_index;
        private System.Windows.Forms.ToolStripMenuItem MNescala;
        private System.Windows.Forms.ToolStripMenuItem MNsobre;
        private System.Windows.Forms.ToolStripMenuItem MNsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ToolStripMenuItem MNcalc_data;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_adm;
        private System.Windows.Forms.ToolStripMenuItem tsmi_criptografiaDeTexto;
    }
}

