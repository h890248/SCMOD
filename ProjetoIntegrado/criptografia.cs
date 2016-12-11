using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    class criptografia
    {
        String chaveBase ="ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789";
        int pulo = 4;

        public String toCode (String text){
            text = text.ToUpper();
            char[] array_texto = text.ToCharArray();
            int i = -1;
            foreach (char letra in array_texto)
            {
                Console.WriteLine("lll == " + letra);
                i++;
                if (chaveBase.IndexOf(letra)> -1)
                {
                    if ((chaveBase.IndexOf(letra) + pulo) > 36)
                    {
                        int pulo_tmp = (pulo + chaveBase.IndexOf(letra)) -37;
                        char letra_nova = chaveBase[pulo_tmp];
                        Console.WriteLine("letra_nova == " + letra_nova);
                        Console.WriteLine("array_texto[i] == " + array_texto[i]);
                        array_texto[i] = letra_nova;
                    }
                    else
                    {
                        char letra_nova = chaveBase[chaveBase.IndexOf(letra) + pulo];
                        Console.WriteLine("letra_nova == " + letra_nova);
                        Console.WriteLine("array_texto[i] == " + array_texto[i]);
                        array_texto[i] = letra_nova;
                    }
                }
            }
            text = new string(array_texto);
            text = text.Replace('A', '*').Replace('E', '#').Replace('I', '+').Replace('O', '-').Replace('U', '$');
            return text;
        }

        public String toText (String code)
        {


            code = code.ToUpper();
            code = code.Replace('*', 'A').Replace('#', 'E').Replace('+', 'I').Replace('-', 'O').Replace('$', 'U');
            char[] array_texto = code.ToCharArray();
            int i = -1;
            foreach (char letra in array_texto)
            {
                Console.WriteLine("letra == " + letra);
                i++;
                if (chaveBase.IndexOf(letra) > -1)
                {
                    Console.WriteLine("chaveBase.IndexOf(letra) - pulo === ", (chaveBase.IndexOf(letra) - pulo));
                    if ((chaveBase.IndexOf(letra) - pulo) < 0)
                    {
                        int pulo_tmp = pulo - chaveBase.IndexOf(letra);
                        char letra_nova = chaveBase[37 - pulo_tmp];
                        Console.WriteLine("letra_nova == " + letra_nova);
                        Console.WriteLine("array_texto[i] == " + array_texto[i]);
                        array_texto[i] = letra_nova;
                    }
                    else
                    {
                        char letra_nova = chaveBase[chaveBase.IndexOf(letra) - pulo];
                        Console.WriteLine("letra_nova == " + letra_nova);
                        Console.WriteLine("array_texto[i] == " + array_texto[i]);
                        array_texto[i] = letra_nova;
                    }
                }
            }
            code = new string(array_texto);
            return code;
        }
    }
}
