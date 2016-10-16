using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    class calculadora_data
    {
        private DateTime DATA_ATUAL = System.DateTime.Now.AddSeconds(1);
        
        // Funçoes Auxiliares
        private int calcula_diferenca_anos(DateTime data1, DateTime data2)
        {
            int meses = ((data1.Year - data2.Year) * 12) + (data1.Month - data2.Month);
            if (data1.Day < data2.Day)
            {
                meses--;
            }
            return (int) (meses / 12d);
        }

        private int calcula_diferenca_meses(DateTime data1, DateTime data2)
        {
            int meses = ((data1.Year - data2.Year) * 12) + (data1.Month - data2.Month);
            if (data1.Day < data2.Day)
            {
                meses--;
            }
            return (int) meses;
        }

        private int calcula_diferenca_dias(DateTime data1, DateTime data2)
        {
            return (int) data1.Subtract(data2).TotalDays;
        }

        private int calcula_diferenca_horas(DateTime data1, DateTime data2)
        {
            return (int)data1.Subtract(data2).TotalHours;
        }

        private int calcula_diferenca_semanas(DateTime data1, DateTime data2)
        {
            return (int)data1.Subtract(data2).TotalDays/7;
        }

        public Boolean validaDiff (DateTime dataMenor, DateTime dataMaior)
        {
            return (DateTime.Compare(dataMenor,dataMaior)>0);
        }

        // REF 3.3
        public StringBuilder idade_total (DateTime dataNascimento)
        {
            if (validaDiff(dataNascimento,DATA_ATUAL))
                throw new System.ArgumentException("Data de Nascimento tem que ser menor que o dia atual !");

            Console.Out.WriteLine(dataNascimento);
            Console.Out.WriteLine(DATA_ATUAL);
            StringBuilder saida = new StringBuilder();
            saida.Append(calcula_diferenca_anos(DATA_ATUAL,dataNascimento));
            saida.Append(" - Anos / ");
            saida.Append(calcula_diferenca_meses(DATA_ATUAL, dataNascimento));
            saida.Append(" - Meses / ");
            saida.Append(calcula_diferenca_dias(DATA_ATUAL, dataNascimento));
            saida.Append(" - Dias / ");
            saida.Append(calcula_diferenca_horas(DATA_ATUAL, dataNascimento));
            saida.Append(" - Horas.");
            Console.Out.WriteLine(saida);
            return saida;
        }

        // REF 3.4
        public StringBuilder calcula_hdma_entre_datas(DateTime data1, DateTime data2)
        {
            if (validaDiff(data2, data1))
                throw new System.ArgumentException("Data Inicial não pode ser maior que a Data Final !");

            StringBuilder saida = new StringBuilder();
            saida.Append(calcula_diferenca_anos(data1, data2));
            saida.Append(" - Anos / ");
            saida.Append(calcula_diferenca_meses(data1, data2));
            saida.Append(" - Meses / ");
            saida.Append(calcula_diferenca_semanas(data1, data2));
            saida.Append(" - Semanas / ");
            saida.Append(calcula_diferenca_dias(data1, data2));
            saida.Append(" - Dias / ");
            saida.Append(calcula_diferenca_horas(data1, data2));
            saida.Append(" - Horas.");
            return saida;
        }

        // REF 3.5
        public DateTime calcula_somadata_dias(DateTime data1, int dias) 
        {
            return data1.AddDays(dias);
        }
        public DateTime calcula_somadata_meses(DateTime data1, int meses)
        {
            return data1.AddMonths(meses);
        }

        // REF 3.6
        public DateTime calcula_subtraidata_dias(DateTime data1, int dias)
        {
            return data1.AddDays(-dias);
        }
        public DateTime calcula_subtraidata_meses(DateTime data1, int meses)
        {
            return data1.AddMonths(-meses);
        }

        // REF 3.7
        public StringBuilder propriedades_data (DateTime data1)
        {
            StringBuilder saida = new StringBuilder();
            saida.Append("[ ");
            saida.Append(System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(data1.DayOfWeek).ToLower());
            saida.Append(" / ");
            saida.Append(System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(data1.Month).ToLower());
            saida.Append(" / ");
            saida.Append(data1.DayOfYear.ToString());
            saida.Append(" é o Dia Juliano / ");
            saida.Append(data1.Year.ToString());
            if (DateTime.IsLeapYear(data1.Year))
                saida.Append(" - É um ano bissexto");
            else
                saida.Append(" - NÃO é um ano bissexto");
            saida.Append(" ]");
            return saida;
        }

        // REF 3.8
        public StringBuilder referencia_data_outros_calendarios(int ano)
        {
            StringBuilder saida = new StringBuilder();
            int islamico, judaico;
            judaico = islamico = ano;
            judaico += 3760;
            islamico = Convert.ToInt32((islamico - 622) * 1.031);
            saida.Append("Islâmico: ");
            saida.Append(islamico);
            saida.Append(Environment.NewLine);
            saida.Append(" -- Judaico: ");
            saida.Append(judaico);
            saida.Append(" -- ");

            switch (ano)
            {
                case 1992: saida.Append("Chinês: Macaco, ano 1992");
                    break;
                case 1993: saida.Append("Chinês: Galo, ano 1993");
                    break;
                case 1996: saida.Append("Chinês: Rato, ano 1996");
                    break;
                case 1997: saida.Append("Chinês: Boi, ano 1997");
                    break;
                case 1999: saida.Append("Chinês: Lebre, ano 1999");
                    break;
                case 2001: saida.Append("Chinês: Cobra, ano 2001");
                    break;
                case 2010: saida.Append("Chinês: Tigre, ano 2010");
                    break;
                case 2015: saida.Append("Chinês: Ovelha, ano 2015");
                    break;
                default: saida.Append("Chinês: Cão, ano 2006");
                    break;
            }
            return saida;
        }

    }
}
