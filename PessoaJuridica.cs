using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabUC_12
{
    public class PessoaJuridica : Pessoa
    {
      //Atributos da classe
      public string cnpj { get; set; }
        
        public string RazaoSocial { get; set; }

       
        public override void PagarImposto(float rendimento){} 
    }
}