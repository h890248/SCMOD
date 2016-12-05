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
    public partial class frm_all_perfil : Form
    {
        String perfil_g;
        public frm_all_perfil(String perfil)
        {
            InitializeComponent();
            switch (perfil)
            {
                case "Administrador":
                    perfil_g = "1";
                    break;
                case "Gerente":
                    perfil_g = "2";
                    break;
                case "Operador":
                    perfil_g  = "3";
                    break;
                case "Estagiario":
                    perfil_g = "4";
                    break;
            }
        }

        private void frm_all_perfil_Load(object sender, EventArgs e)
        {
            verifica_acesso VA = new verifica_acesso();
            ArrayList all = new ArrayList();
            all = VA.todosPorPerfil(perfil_g);
            foreach (user_scmod reg_user in all)
            {
                //string tmp = reg_user.ID.PadRight(11) + reg_user.SENHA.PadRight(11) + reg_user.DATA_ATUALIZACAO.ToShortDateString() + reg_user.NOME.PadRight(30) + reg_user.RG.PadRight(9) + reg_user.STATUS.PadRight(13) + reg_user.PERFIL.ToString().PadRight(1);
                lst_resultado.Items.Add(reg_user.toString());
            }
        }
    }
}
