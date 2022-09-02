namespace TrabUC_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();


            Console.ForegroundColor = ConsoleColor.Green;

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
!              PESSOA FÍSICA                      !
!       1 - Cadastrar pessoa física               !
!       2 - Listar Pessoa Física                  !
!       3 - Remover Pessoa Física                 !
!                                                 !
!                PESSOA JURÍDICA                  !
!       1 - Cadastrar Pessoa Jurídica             !
!       2 - Listar Pessoa Jurídica                !
!       3 - Remover Pessoa Jurídica               !
!                                                 !
!                0 - Sair                         !
!                                                 !
===================================================               
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Cadastrar pessoa física        
                        Endereco endPf = new Endereco();
                        Console.WriteLine("Digite seu Logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número da sua residência");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o complemento da sua residência, se necessário, senão pressione ENTER para pular");
                        endPf.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereço é comercial? (S = Sim ou N = Não)");
                        string endComercial = Console.ReadLine().ToUpper();

                        if (endComercial == "S")
                        {
                            endPf.enderecoComercial = true;
                        }
                        else
                        {
                            endPf.enderecoComercial = false;
                        }


                        PessoaFisica pf = new PessoaFisica();
                        pf.endereco = endPf;

                        Console.WriteLine("Digite seu CPF (Somente números):");
                        pf.cpf = Console.ReadLine();

                        Console.WriteLine("Digite seu nome:");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite o valor do seu salário:");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite sua data de aniversário [AA, MM, DD]");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());
                        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine("cadastro aprovado");
                            listaPf.Add(pf);
                            Console.WriteLine(pf.PagarImposto(pf.salario));
                        }

                        break;

                    case "2":
                        // Listar pessoa física   
                        foreach (var cadaItem in listaPf)
                        {
                            Console.WriteLine($" {cadaItem.nome}, {cadaItem.cpf}");
                        }
                        break;

                    case "3":
                        // Remover pessoa física   
                        Console.WriteLine("Digite o CPF do inadinplente que deseja remover");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Meliante foi removido");
                        }
                        else
                        {
                            Console.WriteLine("cpf não encontrado");
                        }

                        break;

                    case "4":
                        // Cadastrar pessoa jurídica        




                        break;

                    case "5":
                        // Listar pessoa jurídica   




                        break;

                    case "6":
                        // Remover pessoa jurídica   




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