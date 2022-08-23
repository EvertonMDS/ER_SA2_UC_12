using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabUC_12
{
    public class PessoaFisica : Pessoa
    {

        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public override void PagarImposto(float rendimento) { }
                
    //boleano para validar a idade que terá o retorno verdadeiro ou falso
        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}