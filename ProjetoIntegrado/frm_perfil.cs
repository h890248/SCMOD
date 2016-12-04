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
        public frm_perfil(user_scmod reg_user)
        {
            InitializeComponent();
            txt_ID.Text = reg_user.ID;
            txt_nome.Text = reg_user.NOME;
            txt_data.Text = reg_user.DATA_ATUALIZACAO.ToShortDateString();
            txt_perfil.Text = reg_user.PERFIL;
            txt_rg.Text = reg_user.RG;
            txt_senha.Text = reg_user.SENHA;
            txt_status.Text = reg_user.STATUS;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            verifica_acesso VA = new verifica_acesso();
            reg_tmp.ID = txt_ID.Text;
            reg_tmp.NOME = txt_nome.Text;
            reg_tmp.DATA_ATUALIZACAO = DateTime.Parse(txt_data.Text);
            reg_tmp.PERFIL = txt_perfil.Text;
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
            try
            {
                VA.alteraRegistro(reg_tmp);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
