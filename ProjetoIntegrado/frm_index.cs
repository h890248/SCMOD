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
        
        /*
         * Variaveis TEMPORARIAS para a implementação parcial de F6
         */
        double TEMP_COD_USR = 41982059858;
        
        /*
         * FIM de - Variaveis TEMPORARIAS para a implementação parcial de F6
         */
        
        public frm_inicial()
        {
            InitializeComponent();
            txt_user.Select();
            txt_pass.PasswordChar = '*';
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
                        l_grau = valida_senha.qualitativo(txt_pass.Text, txt_user.Text, TEMP_COD_USR);
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
    }
}
