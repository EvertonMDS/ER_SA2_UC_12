namespace TrabUC_12
{
    public class Program
    {
        static void Main(string[] args)
        {


            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(texto);
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("$");
                    Thread.Sleep(500);
                }
            }

            Console.WriteLine(@$"

=================================================== 
===================================================          
!                                                 !
!         Seja Bem Vindo ao nosso Sistema         !
!             de Cadastro de Pessoa               !
!               Fisica e Juridica:                !
!                                                 !
===================================================
===================================================               
");
            //BarraCarregamento ("Start Sistema....")

            string? opcao;

            do
            {
                Console.WriteLine(@$"
=================================================== 
!     Escolha uma das opções abaixo + ENTER:      !          
=================================================== 
!              1 - Pessoa Física                  !
!              2 - Pessoa Jurídica                !
!                                                 !
!              0 - Sair                           !
!                                                 !
===================================================               
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Endereco endPf = new Endereco();

                        endPf.logradouro = "Rua Brigadeiro Marco Antonio Costa";
                        endPf.numero = 230;
                        endPf.complemento = "Apt- Bloco - 2B";
                        endPf.enderecoComercial = false;

                        PessoaFisica Creison = new PessoaFisica();
                        Creison.cpf = "651683864546";
                        Creison.dataNascimento = new DateTime(1984, 08, 21);
                        Creison.endereco = endPf;
                        Creison.nome = "Creison Tabajara";

                        Console.WriteLine("Dados da Pessoa Física:");
                        Console.WriteLine
                        (@$"Nome: {Creison.nome}
CPF: {Creison.cpf} 
Nascido em {Creison.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPf.logradouro}, {endPf.numero}");

                        Console.WriteLine();
                        break;
                    case "2":
                        Endereco endPj = new Endereco();

                        endPj.logradouro = "Rua Niterói";
                        endPj.numero = 180;
                        endPj.complemento = "Escola SENAI";
                        endPj.enderecoComercial = true;

                        PessoaJuridica pj = new PessoaJuridica();
                        pj.cnpj = "0104115487";
                        pj.endereco = endPj;
                        pj.RazaoSocial = "Pessoa Jurídica";
                        pj.nome = "SENAI - Full Stack";

                        Console.WriteLine("Dados da Pessoa Jurídica:");
                        Console.WriteLine(@$"CNPJ: {pj.cnpj}, 
Nome Fantasia: {pj.nome}, 
Endereço da Empresa: {endPj.logradouro}, {endPj.numero}");
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema.");
                        //  BarraCarregamento("Finalizando ");

                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas.");
                        break;
                }
            } while (opcao != "0");

            Console.ResetColor();
        }
    }
}