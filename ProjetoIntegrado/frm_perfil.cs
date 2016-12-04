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
    }
}
