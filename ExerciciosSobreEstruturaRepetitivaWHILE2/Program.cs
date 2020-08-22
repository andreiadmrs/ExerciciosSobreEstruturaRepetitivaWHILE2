using System;

namespace ExerciciosSobreEstruturaRepetitivaWHILE2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/

            Console.WriteLine("Digite 1 para álcool. 2 para Gasolina. 3 para Diesel. 4 para finalizar.");
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo!=4){
                

                if (codigo == 1)
                {
                    alcool=alcool+1;
                }
                else if(codigo == 2)
                {
                    gasolina=gasolina+1;
                }
                if (codigo == 3)
                {
                    diesel=diesel+1;
                }

                Console.WriteLine("Digite 1 para álcool. 2 para Gasolina. 3 para Diesel. 4 para finalizar.");
                codigo = int.Parse(Console.ReadLine());

            }
            
                Console.WriteLine("Muito obrigada!");
                Console.WriteLine($"Alcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {diesel}");
            

        }
    }
}
