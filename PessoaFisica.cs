using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabUC_12
{
    public class PessoaFisica : Pessoa
    {

        public string cpf { get; set; }
        public float salario {get; set;}
        public DateTime dataNascimento { get; set; }
        
        public override float PagarImposto(float salario){

          if  (salario <= 1500)
          {
            return 0;
          }
          else if  (salario >1500 && salario <= 5000)
          {
            return salario *3 / 100;
          }
          else if  (salario >5000)
          {
            return salario *5 / 100;
          }
          else
          {
            return 0;
          }
        }
                
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