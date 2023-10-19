using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TI18N
{
     class ControlFormulario
    {
        model_exeercicio exercicio;
        private int opcao;
        public ControlFormulario()
        {
            exercicio = new model_exeercicio();// Conecta a classe model e a control
            opcao = -1;
        }//Fim do método construtor

        // Métodos Modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do Método

     
        public void Menu()
        {
            Console.WriteLine("\n\n ---- Menu ---- \n\n" +
                "1. Exeercicio 01\n" +
                "2. Exercicio 02\n" +
                "3. Exercicio 03\n" +
                "4. Exercicio 04\n" +
                "5. Exercicio 05\n" +
                "6. Exercicio 06\n" +
                "7. Exercicio 07\n" +
                "8. Exercicio 08\n" +
                "9. Exercicio 09\n" +
                "10. Exercicio 10\n" +
                " Escolha uma das opções acima:");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }// Mostrar Menu

        public void Operacao()
        {
            do
            {

                Menu();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        double nota1;
                        double nota2;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota de 0 e 10");
                            }//Fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);

                        do
                        {
                            Console.WriteLine("Informe a segunda nota; ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota de 0 e 10");
                            }//Fim da Avaliação
                        } while (exercicio.ValidarNotas(nota2) == true);

                        //Chamar o método da média que está na classe model
                        Console.WriteLine("A Média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;

                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um número");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;


                    case 3:
                        Console.WriteLine("Informe um número:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar Resultado
                        Console.WriteLine("O Antecessor é: " + exercicio.Antecessor(num));
                        break;

                    case 4:
                        double N1;
                        double N2;
                        do
                        {


                            Console.WriteLine("Informe a Base do Retãngulo: ");
                            N1 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarArea(N1) == true)
                            {
                                Console.WriteLine("Informe um valor maior que 0");

                            }//Fim Validação
                        } while (exercicio.ValidarArea(N1) == true);

                        do
                        {
                            Console.WriteLine("Informe a Altura da Retângulo: ");
                            N2 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarArea(N2) == true)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }//Fim Validação
                        } while (exercicio.ValidarArea(N2) == true);


                        //Chamar O método Àrea (Mostrar na tela)
                        Console.WriteLine("As dimensões do retângulo é: " + exercicio.AreaDuasNotas(N1, N2));
                        break;


                    case 5:
                        double Total;
                        double Nulo;
                        double Valido;
                        double Branco;
                        double Votos;
                        
                        


                        do
                        {

                           Console.WriteLine("Informe o Total de Votos: ");
                           Total = Convert.ToDouble(Console.ReadLine());
                           if (exercicio.ValidarVotos(Total) == true)
                           {
                                Console.WriteLine("Informe um número positivo");

                           }//Fim Validação
                        }while (exercicio.ValidarVotos(Total) == true);


                        do
                        {

                            Console.WriteLine("Informe o total de Números Validos");
                            Valido = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarVotos(Valido) == true)
                            {

                                Console.WriteLine("Informe um número positivo");

                            }//Fim validação

                        } while (exercicio.ValidarVotos(Valido) == true);


                        do
                        {
                            Console.WriteLine("Informe o total de números Brancos");
                            Branco = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarVotos(Branco) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }//Fim Validação

                        } while (exercicio.ValidarVotos(Branco) == true);


                        do
                        {
                            Console.WriteLine("Informe o total de números Nulo");
                            Nulo = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarVotos(Nulo) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }//Fim Validação

                        } while (exercicio.ValidarVotos(Nulo) == true);


                        //Fazer calculo e Mostrar na tela
                        if (Branco + Valido + Nulo == Total)
                        {
                            Console.WriteLine("\nHá: " + exercicio.PercentualVotos(Branco, Total) + "% de votos brancos" +
                                "\nHá: " + exercicio.PercentualVotos(Nulo, Total) + "% de votos Nulos" + 
                                "\nHá: " + exercicio.PercentualVotos(Valido, Total) + "% de votos Validos");
                        }
                        break;



                    case 6:
                        double salario;
                        double Reajuste;

                        do
                        {
                            Console.WriteLine("Informe o salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarSalario(salario) == true) 
                            {
                                Console.WriteLine("Informe um valor positivo: ");
                            }//Fim validação



                        }while (exercicio.ValidarSalario(salario) == true);

                        do
                        {
                            Console.WriteLine("Informe o Percentual de reajuste: ");
                            Reajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarSalario(Reajuste) == true)
                            {
                                Console.WriteLine("Informe um valor positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarSalario(Reajuste) == true);

                        //Mostrar na tela
                        Console.WriteLine("O novo salário é: " + exercicio.NovoSalario(salario, Reajuste));
                        break;

                    case 7:
                        double CustoFabrica;
                        double Imposto;
                        double Distribuidora;

                        do
                        {
                            Console.WriteLine("Informe o Custo de Fabrica: ");
                            CustoFabrica = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(CustoFabrica) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");

                            }//Fim Validação

                        } while (exercicio.ValidarCusto(CustoFabrica) == true);

                        do
                        {
                            Console.WriteLine("Informe o Imposto: ");
                            Imposto = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(Imposto) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");

                            }//Fim Validação
                        } while (exercicio.ValidarCusto(Imposto) == true);

                        do
                        {
                            Console.WriteLine("Informe o valor da Distribuidora: ");
                            Distribuidora = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarSalario(Distribuidora) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");

                            }//Fim validação

                        } while (exercicio.ValidarCusto(Distribuidora) == true);

                        //Mostrar na tela
                        Console.WriteLine("O custo Final é: " + exercicio.CustoFinal(CustoFabrica, Distribuidora, Imposto));
                        break;

                    case 8:

                        double SalarioFixo;
                        double ValorPorCarro;
                        double NumeroCarro;
                        double TotalVendas;
                        double Comissao;

                        do
                        {
                            Console.WriteLine("Informe o Salário Fixo: ");
                            SalarioFixo = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(SalarioFixo) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarCusto(SalarioFixo) == true);

                        do
                        {
                            Console.WriteLine("Informe o Valor do Carro: ");
                            ValorPorCarro = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(ValorPorCarro) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarCusto(ValorPorCarro) == true);

                        do
                        {
                            Console.WriteLine("Informe a Quantidade de Carros: ");
                            NumeroCarro = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(NumeroCarro) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarCusto(NumeroCarro) == true);

                        do
                        {
                            Console.WriteLine("Informe o Total de Vendas: ");
                            TotalVendas = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(TotalVendas) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarCusto(TotalVendas) == true);

                        do
                        {
                            Console.WriteLine("Informe a Comissão: ");
                            Comissao = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarCusto(Comissao) == true)
                            {
                                Console.WriteLine("Informe um número positivo: ");
                            }//Fim validação

                        } while (exercicio.ValidarCusto(Comissao) == true);


                        //Mostrar na tela
                        Console.WriteLine("O Salário Final do Vendedor é: " + exercicio.SalarioFinal(SalarioFixo, ValorPorCarro) +
                           exercicio.SalarioFinal(SalarioFixo, NumeroCarro) +
                           exercicio.SalarioFinal(SalarioFixo, TotalVendas) +
                           exercicio.SalarioFinal(SalarioFixo, Comissao));
                        break;

                        //Mostrar na tela
                        Console.WriteLine("O Salário Final do Vendedor é: " + exercicio.SalarioFinal(SalarioFixo, ValorPorCarro) +
                            exercicio.SalarioFinal(SalarioFixo, NumeroCarro) +
                            exercicio.SalarioFinal(SalarioFixo, TotalVendas) +
                            exercicio.SalarioFinal(SalarioFixo, Comissao));

                        Console.WriteLine("O salário Final é: " + exercicio.SalarioFinal2(SalarioFixo, ValorPorCarro, NumeroCarro, TotalVendas, Comissao));





                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//Fim escolha 
            } while (ConsultarOpcao != 0); 

        }//fim método
    }//Fim da classe
}//Fim Projeto
