using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI18N
{
     class Program
    {
        static void Main(string[] args)
        {

            //Conectar a control com a Program
            ControlFormulario control = new ControlFormulario();//Instanciando
            control.Operacao();

            //Mantar Aberto
            Console.ReadLine();

        }// Fim do método main
    }//Fim da classe Program 
}//Fim do projeto
