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
    public partial class frm_adm : Form
    {
        int  sflag = 0;

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
        }

        private void frm_adm_Load(object sender, EventArgs e)
        {
            gb_registro.Enabled = false;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            gb_registro.Enabled = true;
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
            reg_tmp.SENHA = "1234";
            reg_tmp.STATUS = "SENHA INICIAL";
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
                if (VA.incluiRegistro(reg_tmp))
                {
                    MessageBox.Show("Incluido com sucesso !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            limpa_texto_registro(this, typeof(TextBox));
        }
    }
}
