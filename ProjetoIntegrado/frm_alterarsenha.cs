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
    public partial class frm_alterarsenha : Form
    {
        user_scmod reg_user;
        public frm_alterarsenha(user_scmod reg_user)
        {
            InitializeComponent();
            this.reg_user = reg_user;
            txt_senha.PasswordChar = '*';
            txt_confirm.PasswordChar = '*';
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            verifica_acesso VA = new verifica_acesso();
            if (txt_senha.Text == txt_confirm.Text)
            {
                try{
                    reg_user.SENHA = txt_senha.Text;
                    if (valida_senha.restritivo(txt_senha.Text))
                    {
                        if (VA.alteraRegistro(reg_user))
                        {
                            MessageBox.Show("Senha Alterada com sucesso !!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Senhas não sao iguais", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
