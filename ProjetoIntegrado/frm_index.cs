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
        String TEMP_USUARIO = "";
        String TEMP_SENHA = "";
        public frm_inicial()
        {
            InitializeComponent();
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
            Boolean resultado;
            try
            { 
                string senha;
                senha = txt_pass.Text;
                resultado = valida_senha.restritivo(senha);
                if (resultado == true)
                    MessageBox.Show("sucesso");

            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ll_alterar_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /*
         * RF 6.4
         * 
            Pontuação negativa no caso de ocorrência dos critérios acima:
            Critérios  3,4        ->  -1 cada
            Critérios  1,2,5,6  ->  -2 cada
            Critérios  7,8        ->  -3 cada

            RF 6.4- Partindo de 10 pontos e usando o critério de pontuação negativa acima, apurar a “nota final da senha”, que deverá ser mostrada ao usuário usando a seguinte graduação:
            Notas 9 ou 10 ->  Muito Forte
            Notas 7 ou 8 ->   Forte
            Notas 5 ou 6 ->   Razoável
            Notas 3 ou 4 ->   Fraca
            Abaixo de 3  ->   Muito Fraca
       */
    }
}
