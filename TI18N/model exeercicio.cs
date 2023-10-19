using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI18N
{
    internal class model_exeercicio
    {
        public model_exeercicio()
        {


        }//Fim do construtor

        //Exercicio 1: Média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2);


        }//Fim do método média

        //Método validação
        public Boolean ValidarNotas(double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercicio 2 - Mostrar o maior
        public int Comparar(int num1, int num2)
        {

            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//Fim de comparar

        //Exercicio 3 - Mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//Fim do Antecessor


        //Exercicio 4 - Calcular área do retangulo
        public double AreaDuasNotas(double N1, double N2)
        {
            return (N1 * N2) / 2;
        }//Fim da Àrea

        //Método Validação
        public Boolean ValidarArea(double N)
        {
            if (N < 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//Fim Validação

        //Exercicio 5 - percentual do total de Eleitores
        public double PercentualVotos(double votos, double total)
        {
            return (votos * 100) / total;
        }//Fim Método

        public Boolean ValidarVotos(double num)
        {

            if (num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }// Fim Validação


        //Exercicio 6 - Novo Salário
        public double NovoSalario(double salario, double Reajuste)
        {
            return salario + (salario * (Reajuste / 100));
        }//Fim metodo

        //Validação
        public Boolean ValidarSalario (double num)
        {
            if (num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//Fim Validação



        // Exercicio 7 - Custo Final ao Consumidor
        public double CustoFinal(double CustoFabrica, double Distrbuidora, double Imposto)
        {
            return CustoFabrica + (CustoFabrica * (Distrbuidora / 100)) + (CustoFabrica * (Imposto / 100));
          
        }//Fim método

        //Validação
        public Boolean ValidarCusto (double num)
        {
            if (num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//Fim validação

        //Exercicio 8 - SalárioFinal
        public double SalarioFinal( double SalarioFixo, double Comissao)
        {
            return SalarioFixo * (Comissao / 100);
        }// Fim método

        // Exercicio 8 - SalárioFinal2
        public double SalarioFinal2(double SalarioFixo, double ValorPorCarro, double NumeroCarro, double TotalVendas, double comissao)
        {
            return SalarioFixo + (ValorPorCarro * NumeroCarro) + (TotalVendas * (comissao / 100));
        }// Fim SalárioFinal2






    }//Fim da Classe 
}//Fim projeto
