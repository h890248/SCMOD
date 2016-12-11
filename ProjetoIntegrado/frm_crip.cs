using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrado
{
    public partial class frm_crip : Form
    {
        string arquivo;

        public frm_crip()
        {
            InitializeComponent();
        }

        private void btn_crip_Click(object sender, EventArgs e)
        {
            if (rtb_crip.Text != "")
            {
                criptografia crip = new criptografia();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Abrir Arquivo Criptografado";
                    saveFileDialog.InitialDirectory = @"c:\Program Files";
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        arquivo = saveFileDialog.FileName;
                    }
                }
                if (String.IsNullOrEmpty(arquivo))
                {
                    MessageBox.Show("Arquivo Invalido", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        File.WriteAllText(arquivo, crip.toCode(rtb_crip.Text));
                        MessageBox.Show("Salvo com Sucesso", "Aviso", MessageBoxButtons.OK);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                rtb_crip.Text = "";
            }
            else
            {
                MessageBox.Show("Campo de texto não pode estar Nulo !!!");
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            criptografia crip = new criptografia();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Salvar Arquivo Criptografado";
                openFileDialog.InitialDirectory = @"c:\Program Files"; 
                openFileDialog.Filter = "txt files (*.txt)|*.txt"; 
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    arquivo = openFileDialog.FileName; 
                }
            }
            if (String.IsNullOrEmpty(arquivo)) 
            {
                MessageBox.Show("Arquivo Invalido", "Aviso", MessageBoxButtons.OK);
            }else{
                using (StreamReader linha = new StreamReader(arquivo))
                {
                   
                        string file_cri = linha.ReadToEnd();
                        rtb_crip.Text = crip.toText(file_cri);
                }
            }
        }
    }
}
