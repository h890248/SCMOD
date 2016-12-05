using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    class valida_senha
    {
        // REF 6.2
        public static Boolean restritivo(string senha) 
        {
            int i,j,repetido=0; //usadas no for

            if(senha.Length< 7 || senha.Length>11) //verifica quantidade de caracteres
               throw new System.ArgumentException(" A senha deve conter no mínimo 7 e no máximo 11 algarismos.");
            if (!(senha.All(c => char.IsLetter(c) || char.IsDigit(c)))) //verifica caracteres especiais e espaço
                throw new System.ArgumentException(" A senha não aceita caracteres especiais, matemáticos e espeços.");
            if (senha.Where(c => char.IsLetter(c)).Count() <3) // verifica se contem no minimo 3 letras
                throw new System.ArgumentException(" A senha deve conter no mínimo 3 letras.");
            if (senha.Where(c => char.IsNumber(c)).Count() <2) //verifica se contem no minimo 3 numeros
                throw new System.ArgumentException(" A senha deve conter no mínimo 2 números.");
            for (i=1,j=0;i<senha.Length;i++) // verifica caracteres repetidos em sequencia
             {
                if (senha[j] == senha[i])
                    repetido++;
                else
                    repetido = 0;
                j += 1;
                if (repetido==2)
                    throw new System.ArgumentException(" A senha não aceita 3 caracteres repetidos em sequência.");
        }
            /*
                Falta fazer esse requisito, criar uma variavel inicializada ou
                pedir comparar duas senhas digitadas pelo usuario?
                 8.	Não ser exatamente igual à senha atual (que está sendo trocada).
             */
            return true;
        }

        // REF 6.3
        public static int qualitativo(string senha, string nome_usuario, string codigo_usuario)
        {
            int nota = 10;
            int i = 0;
            // Boolean verifica = false;

            //1.	Números sequenciais crescentes com 4 ou + algarismos.   Ex.: 12345
            //2.	Números sequenciais decrescentes com 4 ou+ algarismos.
            int j,cr=1,d=1,n=0;
      
            for(i=0;i<senha.Length;i++)
            {
                if (char.IsDigit(senha[i]))
                {
                    n++;
                    if(i > 0)
                    {
                        j=i-1;
                        if (char.IsDigit(senha[j]))
                            if(senha[i]-senha[j]==1)
                                cr++;
                            else if(senha[i]-senha[j]==-1)
                                d++;
                    }
                }

            }

            if (n >= 4)
                if (cr == n || d == n)
                    nota = nota - 2;
        
                    i = 0;

            //3.	Apenas 3 letras  OK
            if (senha.Where(c => char.IsLetter(c)).Count() == 3)
            {
                nota--;
            }

            //4.	Apenas 2 algarismos numéricos OK
            if (senha.Where(c => char.IsNumber(c)).Count() == 2)
            {
                nota--;
            }

            //5.	Os oito (8) primeiros números do código do usuário contido na senha (o código do usuário é o CPF, com 11 algarismos) OK
            string codigo = codigo_usuario.ToString();
            if (senha.Contains(codigo))
            {
                nota = nota - 2;
            }

            //6.	nome do usuário (primeiro nome) contido na senha (30 caracteres)  OK
            nome_usuario = string.Concat(nome_usuario, " ");
            String[] nomes = nome_usuario.Split(' ');
            string primeiro_nome = nomes[0];
            if (senha.Contains(primeiro_nome))
            {
                nota = nota - 2;
            }

            //7.	iniciais do nome do usuário    Ex.:  Ana Maria Castro  ->  AMC  OK
            int count = 0;
            String[] substrings = nome_usuario.Split(' ');
            string iniciais = primeiro_nome[0].ToString();
            string aux = " ";
            for (count = 1; count < substrings.Length-1; count++) 
            {
                aux = substrings[count];
                iniciais = string.Concat(iniciais , aux[0]);
                Console.WriteLine(iniciais);
            }

            if (senha.Contains(iniciais))
            {
                nota = nota - 3;
            }

            //8.	qualquer data válida (uma data correta, passada, futura ou hoje)
            DateTime resultado = DateTime.MinValue; //Retorna se a data é válida
            if (DateTime.TryParse(senha, out resultado))
            {
                nota = nota - 3;
            }
            return nota;
        }

        // REF 6.4 e REF 6.6
        public static string define_grau (int nota)
        {
            string grau = " ";
            switch (nota)
            {
                case 10:
                case 9:
                    grau = "Muito Forte";
                    break;
                case 8:
                case 7:
                    grau = "Forte";
                    break;
                case 6:
                case 5:
                    grau = "Razoável";
                    break;
                case 4:
                case 3:
                    grau = "Fraca";
                    break;
                case 2:
                case 1:
                    grau = "Muito Fraca";
                    throw new System.ArgumentException(" Senha muito fraca! Escolha uma nova senha. ");
            }
            return grau;
        }
    }
}
