using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    class verifica_acesso
    {
        string arquivo;
        string registro;
        public user_scmod reg_user = new user_scmod();

        private void abrirBD()
        {
            arquivo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            arquivo += @"\BD.txt";
            Console.WriteLine("arquivo: " + arquivo);
            if (!System.IO.File.Exists(arquivo))
                throw new System.AccessViolationException("Arquivo de Banco Invalido !!");
        }
        
        public Boolean pesquisa_BD (String ID , String senha, out Boolean troca_senha, out user_scmod out_reg_user){
            abrirBD();
            Boolean usuario_cadastrado = false;
            troca_senha = false;
            using (StreamReader linha = new StreamReader(arquivo))
            {
                while ((registro = linha.ReadLine()) != null)
                {
                    Console.WriteLine(registro.ToString());
                    Console.WriteLine("-----------------------------");
                    reg_user.ID = registro.Substring(0, 11);
                    Console.WriteLine("ID:" + reg_user.ID);
                    reg_user.SENHA = registro.Substring(11, 11);
                    Console.WriteLine("SENHA:" + reg_user.SENHA);
                    reg_user.DATA_ATUALIZACAO=DateTime.Parse(registro.Substring(22, 10));
                    Console.WriteLine("DATA_ATUALIZACAO:" + reg_user.DATA_ATUALIZACAO);
                    reg_user.NOME = registro.Substring(32,30);
                    Console.WriteLine("NOME:" + reg_user.NOME);
                    reg_user.RG = registro.Substring(62,9);
                    Console.WriteLine("RG:" + reg_user.RG);
                    reg_user.STATUS = registro.Substring(71, 13);
                    Console.WriteLine("STATUS:" + reg_user.STATUS);
                    reg_user.PERFIL= registro.Substring(84,1);
                    Console.WriteLine("PERFIL:" + reg_user.PERFIL);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine(reg_user.ID + "-----" + ID);
                    if (reg_user.ID==ID.PadRight(11))
                    {
                        usuario_cadastrado = true;
                        break;
                    }
                }
                linha.Close();
                if (usuario_cadastrado)
                {
                    Console.WriteLine(reg_user.SENHA + "-----" + senha);
                    if (String.Compare(reg_user.SENHA, senha.PadRight(11)) == 0)
                    {
                        DateTime DATA_ATUAL = System.DateTime.Now;
                        if (DATA_ATUAL.Subtract(reg_user.DATA_ATUALIZACAO).TotalDays> 90)
                            troca_senha = true;
                        out_reg_user = reg_user;
                        linha.Close();
                        return true;
                    }
                    else
                    {
                        linha.Close();
                        throw new System.ArgumentException("Senha Invalida.");
                    }
                }
                else
                {
                    linha.Close();
                    throw new System.ArgumentException("Usuario nao existe");
                }
            }
        }

        public Boolean alteraRegistro(user_scmod reg_user)
        {
            abrirBD();
            StreamReader linha = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();
            while (!linha.EndOfStream)
            {
                string s = linha.ReadLine();
                if (s.IndexOf(reg_user.ID) > -1)
                {
                    string tmp = reg_user.ID.PadRight(11) + reg_user.SENHA.PadRight(11) + reg_user.DATA_ATUALIZACAO.ToShortDateString() + reg_user.NOME.PadRight(30) + reg_user.RG.PadRight(9) + reg_user.STATUS.PadRight(13) + reg_user.PERFIL.ToString().PadRight(1);
                    sb.AppendLine(tmp);
                }
                else
                {
                    sb.AppendLine(s);
                }
            }
            linha.Close();
            StreamWriter writer = new StreamWriter(arquivo);
            writer.Write(sb);
            writer.Close();
            return true;
        }
        public Boolean incluiRegistro(user_scmod reg_user)
        {
            abrirBD();
            StreamReader linha = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();
            while (!linha.EndOfStream)
            {
                string s = linha.ReadLine();
                sb.AppendLine(s);
            }
            string tmp = reg_user.ID.PadRight(11) + reg_user.SENHA.PadRight(11) + reg_user.DATA_ATUALIZACAO.ToShortDateString() + reg_user.NOME.PadRight(30) + reg_user.RG.PadRight(9) + reg_user.STATUS.PadRight(13) + reg_user.PERFIL.ToString().PadRight(1);
            sb.AppendLine(tmp);
            linha.Close();
            StreamWriter writer = new StreamWriter(arquivo);
            writer.Write(sb);
            writer.Close();
            return true;
        }

        public StringBuilder todosIDs()
        {
            abrirBD();
            StreamReader linha = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();
            while (!linha.EndOfStream)
            {
                string s = linha.ReadLine();
                sb.AppendLine(s.Substring(0, 11));
            }
            return sb;
        }

        public StringBuilder todosBloqueados()
        {
            abrirBD();
            StreamReader linha = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();
            while (!linha.EndOfStream)
            {
                string s = linha.ReadLine();

                sb.AppendLine(s.Substring(0, 11));
            }
            return sb;
        }

        public StringBuilder todosPorPerfil(string perfil)
        {
            abrirBD();
            StreamReader linha = new StreamReader(arquivo);
            StringBuilder sb = new StringBuilder();
            while (!linha.EndOfStream)
            {
                string s = linha.ReadLine();
                string perfil_linha = s.Substring(84, 1);
                if (perfil == perfil_linha)
                {
                    sb.AppendLine(s.Substring(0, 11));
                }
            }
            return sb;
        }

    }
}
