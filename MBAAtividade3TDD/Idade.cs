using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBAAtividade3TDD
{
    public class Idade
    {
        public string ValidaIdade(string idade)
        {
            string mensagem = "";
            int idadeInteiraConvertida = 0;
            int adulto = 18;
            bool ehInteiro = int.TryParse(idade, out idadeInteiraConvertida);
            if (!ehInteiro)
                mensagem = "Idade é inválida nao é um inteiro";
            
            if (ehInteiro)
                mensagem = "Idade é válida";

            if (ehInteiro && idadeInteiraConvertida <0)
                mensagem = "Idade é inválida menor que zero";

            if (ehInteiro && idadeInteiraConvertida > 130)
                mensagem = "Idade é inválida";

            if (ehInteiro && idadeInteiraConvertida > 0 && idadeInteiraConvertida < adulto)
                mensagem = "Idade é inválida nao é um adulto";



            return mensagem;
        }
    }
}
