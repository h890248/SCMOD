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
    public partial class frm_temperatura : Form
    {
        public frm_temperatura()
        {
            InitializeComponent();
        }
        float cel;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioKelvin_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = "";
            txtresult.Clear();
        }

        private void radioCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = "";
            txtresult.Clear();
        }

        private void radioFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = "";
            txtresult.Clear();
        }

        private void txtcel_TextChanged(object sender, EventArgs e)
        {
            float valor;
            try
            {
                valor = float.Parse(txtresult.Text);
                if (radioCelsius.Checked == true)
                {
                    if (valor < -274 || valor > 101)
                        MessageBox.Show(" Para escala Celsius, digite valores entre -275 e 101", "Aviso");
                    else
                    {
                        cel = valor;
                        lblresult.Text = "Celsius:" + valor.ToString() + "\n" + "Fahrenheit:" + Math.Round(((9 * valor + 160) / 5), 2).ToString() + "\n" +
                        "Kelvin:" + (valor + 273).ToString();
                    }      
                }
                else if (radioKelvin.Checked == true)
                {
                    if (valor < 0 || valor > 374)
                        MessageBox.Show(" Para escala Kelvin, digite valores entre 0 e 374", "Aviso");
                    else
                    {
                        cel = valor - 273;
                        lblresult.Text = "Celsius:" + cel.ToString() + "\n" + "Fahrenheit:" + Math.Round(((9 * valor - 2297) / 5), 2).ToString() + "\n" +
                        "Kelvin:" + valor.ToString();
                    }
                }
                else
                {
                    if (valor < -460 || valor > 213)
                        MessageBox.Show(" Para escala Fahrenheit, digite valores entre -460 e 213", "Aviso");
                    else
                    {
                        cel = (5 * valor - 160) / 9;
                        lblresult.Text = "Celsius:" + Math.Round(cel,2).ToString() + "\n" + "Fahrenheit:" + valor.ToString() +
                        "\n" + "Kelvin:" + (5 * valor + 2297).ToString();
                    }                                       
                } 
                if(cel<=0)
                {
                    pictureBox1.Image = Properties.Resources.frio;
                    lblresult.BackColor = Color.LightBlue;
                }
                     
                else if(cel>0 && cel<40)
                {
                    pictureBox1.Image = Properties.Resources.normal;
                    lblresult.BackColor = Color.OrangeRed;
                }
                    
                else
                {
                    pictureBox1.Image = Properties.Resources.quente;
                    lblresult.BackColor = Color.Red;
                }           
            }
            catch
            {
                MessageBox.Show("Digite apenas valores numéricos");          
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
