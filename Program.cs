namespace TrabUC_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            PessoaFisica pf = new PessoaFisica();
            pf.endereco = end;
            pf.nome = "João da Silva Antunes";
            pf.cpf = "65151546-20";
            pf.dataNascimento = new DateTime(1982, 05, 19);

            Console.WriteLine("**************************** Interpolação ***********************************");

            //interpolação
            Console.WriteLine($"O {pf.nome} mora na Rua: {pf.endereco.logradouro}, número {pf.endereco.numero}, cep:{end.CEP}");

            Console.WriteLine("**********************''******* Concatenação ***********************'***********");

            //concatenação
            Console.WriteLine("O " + pf.nome + " mora na Rua: " + pf.endereco.logradouro + " número "  + pf.endereco.numero + " cep:" + end.CEP);

            Console.WriteLine("***************** Forma despadronizada para executar a ação *********************");

            //forma despadronizada para executar a ação
            Console.WriteLine(pf.endereco.logradouro);
            Console.WriteLine(pf.endereco.numero);
            Console.WriteLine(pf.endereco.CEP);
            Console.WriteLine(pf.endereco.complemento);

            Console.WriteLine("***************************************************************");

            bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

            if (idadeValida == true)
            {
                System.Console.WriteLine("Parabéns, você têm a idade apta para acessar o sistema.");
            }
            else
            {
                Console.WriteLine("Você ainda não atingiu a idade.");
            }

            Console.WriteLine("***************************************************************");
            }
         */

            PessoaJuridica pj = new PessoaJuridica ();
            Endereco end = new Endereco();
            end.logradouro = "Brigadeiro Augusto Carvalho Pereira";
            end.numero = 380;
            end.complemento = "Bloco-F";
            end.CEP = "98037-000";
            end.enderecoComercial = true;

            pj.endereco = end;
            pj.cnpj = "12345678990001";
            pj.RazaoSocial = "Pessoa Juridica";

           if(pj.ValidarCNPJ(pj.cnpj))
           {
            Console.WriteLine("cnpj válido");
           }
            else
            {
               Console.WriteLine("cnpj invalido"); 
            }
        }
    }
}