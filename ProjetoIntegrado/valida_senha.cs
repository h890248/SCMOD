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
        public static int qualitativo (string senha)
        {
            /*
                1.	Números sequenciais crescentes com 4 ou + algarismos.   Ex.: 12345
                2.	Números sequenciais decrescentes com 4 ou+ algarismos.
                3.	Apenas 3 letras
                4.	Apenas 2 algarismos numéricos
                5.	Os oito (8) primeiros números do código do usuário contido na senha (o código do usuário é o CPF, com 11 algarismos)
                6.	nome do usuário (primeiro nome) contido na senha (30 caracteres)
                7.	iniciais do nome do usuário    Ex.:  Ana Maria Castro  ->  AMC
                8.	qualquer data válida (uma data correta, passada, futura ou hoje)
            */
            return 0;
        }
    }
}
