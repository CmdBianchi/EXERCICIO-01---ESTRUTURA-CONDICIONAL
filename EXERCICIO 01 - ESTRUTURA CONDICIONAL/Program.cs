using System;
namespace EXERCICIO_01___ESTRUTURA_CONDICIONAL{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();           
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg() {
            Console.WriteLine("Dizer se este número é negativo ou não");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional() {
            int a;
            Console.Write("Digite o valor numérico inteiro: ");
            a = int.Parse(Console.ReadLine());
            bool c1 = (a >= 0);

            if (c1 == true){
                Console.WriteLine("Postivo");
            }
            else {
                Console.WriteLine("Negativo");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
