using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    public class user_scmod
    {
        public string ID;
        public string SENHA;
        public DateTime DATA_ATUALIZACAO;
        public string NOME;
        public string RG;
        public string STATUS;
        public string PERFIL;
        public String toString()
        {
            return "ID: "  + this.ID + "DATA: "  + "NOME: " + this.NOME + "RG: " + this.RG + "STATUS: " + this.STATUS + "PERFIL: " + this.PERFIL;
        }
    }
}
