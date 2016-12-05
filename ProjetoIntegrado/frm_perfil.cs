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
    public partial class frm_perfil : Form
    {
        user_scmod reg_tmp = new user_scmod();
        verifica_acesso VA = new verifica_acesso();

        public frm_perfil(user_scmod reg_user)
        {
            InitializeComponent();
            txt_senha.PasswordChar = '*';
            txt_data.Enabled = false;
            txt_ID.Enabled = false;
            txt_perfil.Enabled = false;
            txt_senha.Enabled = false;
            txt_status.Enabled = false;
            carrega_dados(reg_user);
            
        }

        private void carrega_dados(user_scmod reg_user)
        {
            Boolean change_pass;
            if (VA.pesquisa_BD(reg_user.ID,reg_user.SENHA,out change_pass,out reg_tmp)){
                txt_ID.Text = reg_tmp.ID;
                txt_nome.Text = reg_tmp.NOME;
                txt_data.Text = reg_tmp.DATA_ATUALIZACAO.ToShortDateString();
                txt_perfil.Text = reg_tmp.PERFIL;
                txt_rg.Text = reg_tmp.RG;
                txt_senha.Text = reg_tmp.SENHA;
                txt_status.Text = reg_tmp.STATUS;
                switch (reg_tmp.PERFIL)
                {
                    case "1":
                        txt_perfil.Text = "Administrador";
                        break;
                    case "2":
                        txt_perfil.Text = "Gerente";
                        break;
                    case "3":
                        txt_perfil.Text = "Operador";
                        break;
                    case "4":
                        txt_perfil.Text = "Estagiario";
                        break;
                }
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            reg_tmp.ID = txt_ID.Text;
            reg_tmp.NOME = txt_nome.Text;
            reg_tmp.DATA_ATUALIZACAO = DateTime.Parse(txt_data.Text);
            reg_tmp.RG = txt_rg.Text;
            reg_tmp.STATUS = txt_status.Text;
            Console.WriteLine(reg_tmp.ToString());
            Console.WriteLine("---------- GRAVAR------------");
            Console.WriteLine("ID:" + reg_tmp.ID);
            Console.WriteLine("SENHA:" + reg_tmp.SENHA);
            Console.WriteLine("DATA_ATUALIZACAO:" + reg_tmp.DATA_ATUALIZACAO);
            Console.WriteLine("NOME:" + reg_tmp.NOME);
            Console.WriteLine("RG:" + reg_tmp.RG);
            Console.WriteLine("STATUS:" + reg_tmp.STATUS);
            Console.WriteLine("PERFIL:" + reg_tmp.PERFIL);
            Console.WriteLine("-----------------------------");
            try
            {
                if (VA.alteraRegistro(reg_tmp))
                {
                    MessageBox.Show("Alteraçoes gravadas com sucesso !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }

        private void lk_alterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg_tmp.ID = txt_ID.Text;
            reg_tmp.NOME = txt_nome.Text;
            reg_tmp.DATA_ATUALIZACAO = DateTime.Parse(txt_data.Text);
            switch (txt_perfil.Text)
            {
                case "Administrador":
                    reg_tmp.PERFIL = "1";
                    break;
                case "Gerente":
                    reg_tmp.PERFIL = "2";
                    break;
                case "Operador":
                    reg_tmp.PERFIL = "3";
                    break;
                case "Estagiario":
                    reg_tmp.PERFIL = "4";
                    break;
            }
            reg_tmp.RG = txt_rg.Text;
            reg_tmp.SENHA = txt_senha.Text;
            reg_tmp.STATUS = txt_status.Text;
            Console.WriteLine(reg_tmp.ToString());
            Console.WriteLine("---------- GRAVAR------------");
            Console.WriteLine("ID:" + reg_tmp.ID);
            Console.WriteLine("SENHA:" + reg_tmp.SENHA);
            Console.WriteLine("DATA_ATUALIZACAO:" + reg_tmp.DATA_ATUALIZACAO);
            Console.WriteLine("NOME:" + reg_tmp.NOME);
            Console.WriteLine("RG:" + reg_tmp.RG);
            Console.WriteLine("STATUS:" + reg_tmp.STATUS);
            Console.WriteLine("PERFIL:" + reg_tmp.PERFIL);
            Console.WriteLine("-----------------------------");
            frm_alterarsenha frm_alterarsenha = new frm_alterarsenha(reg_tmp);
            frm_alterarsenha.Show();
        }
    }
}
