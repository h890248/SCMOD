using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrado
{
    public partial class frm_inicial : Form
    {
        Form Form2 = new ProjetoIntegrado.frm_temperatura();
        Form frm_sobre = new ProjetoIntegrado.frm_about();
        Form frm_calculadata = new ProjetoIntegrado.frm_calculadata();
        Form frm_crip = new ProjetoIntegrado.frm_crip();
        double TEMP_COD_USR;
        string perfil_tipo;
        public user_scmod reg_user = new user_scmod();
        
        public frm_inicial()
        {
            InitializeComponent();
            MNescala.Enabled = true;
            MNcalc_data.Enabled = false;
            txt_user.Select();
            txt_pass.PasswordChar = '*';
            btn_perfil.Visible = false;
            btn_adm.Visible = false;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MNescala_Click(object sender, EventArgs e)
        {
            Form2.ShowDialog();
        }

        private void MNsobre_Click(object sender, EventArgs e)
        {
            frm_sobre.ShowDialog();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNsair_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Close();

        }

        private void MNcalc_data_Click(object sender, EventArgs e)
        {
            frm_calculadata.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            verifica_acesso VA = new verifica_acesso();
            Boolean troca_senha = false;
            try
            {
                if (VA.pesquisa_BD(txt_user.Text.ToString(), txt_pass.Text.ToString(),out troca_senha,out reg_user))
                {
                    if (troca_senha)
                    {
                        MessageBox.Show("Acesso Liberado : Você deve atualizar sua senha o mais breve possivel . \n \nPor mediadas de segurança não é aconselhavel usar a mesma senha por mais de 90 dias", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        frm_alterarsenha frm_alterarsenha = new frm_alterarsenha(reg_user);
                        frm_alterarsenha.Show();
                    }
                    if (reg_user.STATUS== "SENHA INICIAL")
                    {
                        MessageBox.Show("Senha Inicial . \n \nVoce deve trocar a senha AGORA", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        frm_alterarsenha frm_alterarsenha = new frm_alterarsenha(reg_user);
                        frm_alterarsenha.Show();
                    }
                    if (reg_user.STATUS == "bloqueado    ")
                    {
                        MessageBox.Show("Acesso Valido porem seu perfil encontrase Bloqueado", "Acesso Valido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        ativa_perfil(int.Parse(reg_user.PERFIL));
                    }
                    
                    gb_login.Visible = false;
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.AccessViolationException ex)
            {
                MessageBox.Show(ex.Message, "Erro Grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ll_avaliar_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Boolean resultado;
            int l_grau;
            DialogResult resultado_dialogo;
            try
            {
                string senha;
                senha = txt_pass.Text;
                if (txt_user.TextLength <= 0){
                    MessageBox.Show("Campo de Usuario nao pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_user.Focus();
                }
                else
                {
                    
                    resultado = valida_senha.restritivo(senha);
                    if ((resultado == true))
                    {
                        l_grau = 1;
                        try
                        {
                            resultado_dialogo = MessageBox.Show("Senha dentro dos padroes e Aceita com o grau de segurança : " + valida_senha.define_grau(l_grau) + " . \n Deseja Tentar criar uma senha mais forte?", "Senha Aceita", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if (resultado_dialogo == DialogResult.Yes)
                            {
                                txt_user.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Senha Alterada com sucesso !!!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        catch (System.ArgumentException ex)
                        {
                            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_pass.Focus();
                        }

                    }
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pass.Focus();
            }
        }

        private void ativa_perfil(int perfil)
        {
            switch (perfil)
            {
                case 1:
                    MNcalc_data.Enabled = true;
                    perfil_tipo = "Administrador";
                    Console.Write("Chegou aqui");
                    btn_adm.Visible = true;
                    break;
                case 2:
                    MNcalc_data.Enabled = true;
                    perfil_tipo = "Gerente";
                    btn_perfil.Visible = true;
                    break;
                case 3:
                    MNcalc_data.Enabled = true;
                    perfil_tipo = "Operador";
                    btn_perfil.Visible = true;
                    break;
                case 4:
                    MNcalc_data.Enabled = true;
                    perfil_tipo = "Estagiario";
                    btn_perfil.Visible = true;
                    break;
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            Form frm_perfil = new ProjetoIntegrado.frm_perfil(reg_user);
            frm_perfil.ShowDialog();
        }

        private void btn_adm_Click(object sender, EventArgs e)
        {
            Form frm_adm = new ProjetoIntegrado.frm_adm();
            frm_adm.ShowDialog();
        }

        private void tsmi_criptografiaDeTexto_Click(object sender, EventArgs e)
        {
            frm_crip.ShowDialog();
        }
    }
}
