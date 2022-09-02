using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabUC_12
{
    public abstract class Pessoa
    {
        //Atributos da classe
        public string nome { get; set; }
        public Endereco endereco { get; set; }  

        //Métodos da classe
        public abstract float PagarImposto(float rendimento);
    }
}