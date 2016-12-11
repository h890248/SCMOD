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
    public partial class frm_crip : Form
    {
        public frm_crip()
        {
            InitializeComponent();
        }

        private void btn_crip_Click(object sender, EventArgs e)
        {
            criptografia crip = new criptografia();
            rtb_crip.Text = crip.toCode(rtb_crip.Text);
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            criptografia crip = new criptografia();
            rtb_crip.Text = crip.toText(rtb_crip.Text);
        }
    }
}
