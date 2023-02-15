using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil //O internal restringe o uso da classe apenas para outras classes da biblioteca,
                                    //nao permitindo instanciar objetos fora da mesma
    {
        public bool ValidarSenha(string SenhaVerdadeira,string senhaPassada)
        {
            return SenhaVerdadeira.Equals(senhaPassada);
        }

    }
}
