using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProjetoIntegrado
{
    public partial class frm_adm : Form
    {
        int  sflag = 0;
        frm_all_bloqueados frm_all_bloqueados = new frm_all_bloqueados();
        

        private void limpa_texto_registro(Control frm_adm, Type type)
        {
            foreach (Control c in frm_adm.Controls)
            {
                if (c.GetType() == type)
                    c.Text = "";
                else if (c.HasChildren)
                    limpa_texto_registro(c, type);
            }
        }

        public frm_adm()
        {
            InitializeComponent();
            verifica_acesso VA = new verifica_acesso();
            ArrayList ids = VA.todosIDs();
            foreach (String id in ids)
            {
                cmb_alterar.Items.Add(id);
            }
        }

        private void frm_adm_Load(object sender, EventArgs e)
        {
            gb_registro.Enabled = false;
            txt_senha.PasswordChar = '*';
            txt_senha.Enabled = false;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            desativa_menu();
            txt_senha.Enabled = false;
            txt_data.Enabled = false;
            cb_reset_pass.Enabled = false;
            rb_bloqueado.Enabled = false;
            rb_desbloqueado.Enabled = false;
            sflag = 1;
            cmb_inc_perfil.SelectedIndex = 2;
            txt_senha.Text = "Senha Default";
            txt_data.Text = "Data Atual";
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            user_scmod reg_tmp = new user_scmod();
            verifica_acesso VA = new verifica_acesso();
            reg_tmp.ID = txt_ID.Text;
            reg_tmp.NOME = txt_nome.Text;
            reg_tmp.DATA_ATUALIZACAO = System.DateTime.Now;
            switch (cmb_inc_perfil.SelectedItem.ToString())
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
            if ((sflag == 1) || cb_reset_pass.Checked)
            {
                reg_tmp.SENHA = "1234";
                reg_tmp.STATUS = "SENHA INICIAL";
            }
            else
            {
                reg_tmp.SENHA = txt_senha.Text;
                if (rb_bloqueado.Checked)
                    reg_tmp.STATUS = "Bloqueado    ";
                else
                    reg_tmp.STATUS = "Desbloqueado ";
            }
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
                if (sflag == 1)
                {
                    if (VA.incluiRegistro(reg_tmp))
                        MessageBox.Show("Incluido com sucesso !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sflag == 2)
                {
                    if (VA.alteraRegistro(reg_tmp))
                        MessageBox.Show("Alterado com sucesso !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ativa_menu();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ativa_menu();
        }

        private void desativa_menu()
        {
            gb_registro.Enabled = true;
            gb_consulta.Enabled = false;
            gb_alterar.Enabled = false;
            btn_incluir.Enabled = false;
            txt_senha.Enabled = true;
            txt_data.Enabled = true;
            cb_reset_pass.Enabled = true;
            rb_bloqueado.Enabled = true;
            rb_desbloqueado.Enabled = true;
            cmb_inc_perfil.SelectedIndex = 2;
        }

        private void ativa_menu()
        {
            limpa_texto_registro(this, typeof(TextBox));
            cmb_inc_perfil.SelectedIndex = 2;
            rb_bloqueado.Checked = false;
            rb_desbloqueado.Checked = false;
            cb_reset_pass.Checked = false;
            gb_registro.Enabled = false;
            gb_consulta.Enabled = true;
            gb_alterar.Enabled = true;
            btn_incluir.Enabled = true;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sflag = 2;
            if (cmb_alterar.Text == "")
            {
                MessageBox.Show("Selecione um perfil a ser Editado !!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                desativa_menu();
                user_scmod tmp_user = new user_scmod();
                tmp_user.ID = cmb_alterar.Text;
                tmp_user.SENHA = "#admesp";
                carrega_dados(tmp_user);
            }

        }
        private void carrega_dados(user_scmod reg_user)
        {
            Boolean change_pass;
            user_scmod reg_tmp = new user_scmod();
            verifica_acesso VA = new verifica_acesso();
            if (VA.pesquisa_BD(reg_user.ID, reg_user.SENHA, out change_pass, out reg_tmp))
            {
                txt_ID.Text = reg_tmp.ID;
                txt_nome.Text = reg_tmp.NOME;
                txt_data.Text = reg_tmp.DATA_ATUALIZACAO.ToShortDateString();
                txt_rg.Text = reg_tmp.RG;
                txt_senha.Text = reg_tmp.SENHA;
                switch (reg_tmp.STATUS)
                {
                    case "SENHA INICIAL":
                        rb_sinicial.Checked = true;
                        break;
                    case "Bloqueado    ":
                        rb_bloqueado.Checked = true;
                        break;
                    case "Desbloqueado ":
                        rb_desbloqueado.Checked = true;
                        break;
                }
                switch (reg_tmp.PERFIL)
                {
                    case "1":
                        cmb_inc_perfil.Text = "Administrador";
                        break;
                    case "2":
                        cmb_inc_perfil.Text = "Gerente";
                        break;
                    case "3":
                        cmb_inc_perfil.Text = "Operador";
                        break;
                    case "4":
                        cmb_inc_perfil.Text = "Estagiario";
                        break;
                }
            }
        }

        private void btn_list_bloqueado_Click(object sender, EventArgs e)
        {
            frm_all_bloqueados.Show();
        }

        private void btn_list_perfil_Click(object sender, EventArgs e)
        {
            frm_all_perfil frm_all_perfil = new frm_all_perfil(cmb_perfil.Text);
            frm_all_perfil.Show();
        }
    }
}
