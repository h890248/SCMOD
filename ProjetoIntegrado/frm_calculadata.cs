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
    public partial class frm_calculadata : Form
    {
        calculadora_data c_calculadora_data = new calculadora_data();
        public frm_calculadata()
        {
            InitializeComponent();
            cmb_prop_data_other_calen.SelectedIndex = 0;
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_nascimento.Enabled = true;
            rdb_cal_nascimento.Enabled = true;
        }


        /* 
         * 
         * Fuções de validação de entrada e controle de componentes do formulario 
         * 
         */

        private void txt_soma_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        private void txt_sub_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        private void desabilita_componente(Control frm_calculadata, Type type)
        {
            foreach (Control c in frm_calculadata.Controls)
            {
                if (c.GetType() == type)
                    c.Enabled = false;
                else if (c.HasChildren)
                    desabilita_componente(c,type);
            }
        }
        private void rdb_cal_nascimento_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_nascimento.Enabled = true;
        }

        private void rdb_cal_entre_datas_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_entre_datas_inicial.Enabled = true;
            dtp_cal_entre_datas_final.Enabled = true;
        }

        private void rdb_cal_data_futura_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_data_futura.Enabled = true;
            gb_somar.Enabled = true;
        }

        private void rdb_cal_data_passada_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_data_passada.Enabled = true;
            gb_subtrair.Enabled = true;
        }

        private void rdb_prop_data_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_prop_data.Enabled = true;
        }

        private void rdb_prop_data_other_calen_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            cmb_prop_data_other_calen.Enabled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            cmb_prop_data_other_calen.SelectedIndex = 0;
            desabilita_componente(this, typeof(DateTimePicker));
            desabilita_componente(this, typeof(ComboBox));
            desabilita_componente(this, typeof(GroupBox));
            dtp_cal_nascimento.Enabled = true;
            rdb_cal_nascimento.Enabled = true;
        }


        /* 
         * 
         * Funçoes para o processamento dos dados 
         * 
         */

        private void btn_processar_Click(object sender, EventArgs e)
        {
            if (rdb_cal_nascimento.Checked)
            {
                try
                {
                    lst_resultado.Items.Add(c_calculadora_data.idade_total((DateTime)dtp_cal_nascimento.Value));
                }
                catch (System.ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (rdb_cal_entre_datas.Checked)
            {
                try
                {
                    lst_resultado.Items.Add(c_calculadora_data.calcula_hdma_entre_datas((DateTime)dtp_cal_entre_datas_final.Value, (DateTime)dtp_cal_entre_datas_inicial.Value));
                }
                catch (System.ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (rdb_cal_data_futura.Checked)
            {
                int tempo = Int32.Parse(txt_soma_valor.Text);
                if (rdb_soma_dias.Checked)
                {
                    lst_resultado.Items.Add("Data Futura: " + c_calculadora_data.calcula_somadata_dias((DateTime)dtp_cal_data_futura.Value, tempo));
                }
                else if (rdb_soma_semanas.Checked)
                {
                    lst_resultado.Items.Add("Data Futura: " + c_calculadora_data.calcula_somadata_dias((DateTime)dtp_cal_data_futura.Value, tempo * 7));
                }
                else if (rdb_soma_meses.Checked)
                {
                    lst_resultado.Items.Add("Data Futura: " + c_calculadora_data.calcula_somadata_meses((DateTime)dtp_cal_data_futura.Value, tempo));
                }

            }
            else if (rdb_cal_data_passada.Checked)
            {
                int tempo = Int32.Parse(txt_sub_valor.Text);

                if (rdb_sub_dias.Checked)
                {
                    lst_resultado.Items.Add("Data Anterior: "+c_calculadora_data.calcula_subtraidata_dias((DateTime)dtp_cal_data_passada.Value, tempo));
                }
                else if (rdb_sub_semanas.Checked)
                {
                    lst_resultado.Items.Add("Data Anterior: " + c_calculadora_data.calcula_subtraidata_dias((DateTime)dtp_cal_data_passada.Value, tempo * 7));
                }
                else if (rdb_sub_meses.Checked)
                {
                    lst_resultado.Items.Add("Data Anterior: " + c_calculadora_data.calcula_subtraidata_meses((DateTime)dtp_cal_data_passada.Value, tempo));
                }

            }
            else if (rdb_prop_data.Checked)
            {
                lst_resultado.Items.Add(c_calculadora_data.propriedades_data((DateTime)dtp_prop_data.Value));
            }
            else if (rdb_prop_data_other_calen.Checked)
            {
                int year = int.Parse(cmb_prop_data_other_calen.SelectedItem.ToString());
                lst_resultado.Items.Add(c_calculadora_data.referencia_data_outros_calendarios(year).ToString());
            }
        }
    }
}
