using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
    class ExerciciosAula01
    {

        public float ValidarFloat(String text, String input)
        {
            float outputValue;
            while (!float.TryParse(input, out outputValue))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido");
                Console.WriteLine(text + ": " );
                input = Console.ReadLine();
            }
            return outputValue;
        }

        public float ValidarInt(String text, String input)
        {
            int outputValue;
            while (!int.TryParse(input, out outputValue))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido");
                Console.WriteLine(text + ": ");
                input = Console.ReadLine();
            }
            return outputValue;
        }


        public void Exercicio01()
        {
            /*
             *  Crie um programa que: 
             *      Leia a cotação do dólar
             *      Leia um valor em dóláres
             *      Converta esse valor para Real
             *      Mostre o Resultado
             */

            float cotacao, moeda, real;
            string perguntaCotacao = "Qual a cotacao do dolar?",
                   perguntaDolar = "Valor do dólar a ser convertido";

            Console.WriteLine(perguntaCotacao);
            var input = Console.ReadLine().Replace(".", ",");
            cotacao = ValidarFloat(perguntaCotacao, input);

            Console.WriteLine(perguntaDolar);
            input = Console.ReadLine().Replace(".", ",");
            moeda = ValidarFloat(perguntaDolar, input);

            real = moeda * cotacao;
            Console.WriteLine("Valor em Real:"  + real);
            Console.ReadLine();
        }

        public void Exercicio02()
        {
            /*
             * Crie um programa para ler uma temperatura
             * em graus celsius e apresentá-la convertida
             * em graus fahrenheit
             */
            float celsius, fahrenheit;
            string perguntaCelsius = "Qual a temperatura em Celsius?";

            Console.WriteLine(perguntaCelsius);
            var input = Console.ReadLine().Replace(".", ",");
            celsius = ValidarFloat(perguntaCelsius, input);

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("conversão em Fahrenheit:" + fahrenheit + " F");
            Console.ReadLine();

        }
        
        public void Exercicio03()
        {
            /*
             * Crie um programa que pergunte peso e altura e 
             * calcule o IMC e exiba os resultados, e as mensagens.
             */
            float peso, altura, imc;
            string perguntaPeso = "Qual seu peso(Em kilogramas): ",
                   perguntaAltura = "Qual sua altura(Em metros): ";

            Console.WriteLine(perguntaPeso);
            var input = Console.ReadLine().Replace(".", ",");
            peso = ValidarFloat(perguntaPeso, input);

            Console.WriteLine(perguntaAltura);
            input = Console.ReadLine().Replace(".", ",");
            altura = ValidarFloat(perguntaAltura, input);

            altura = (float)Math.Pow(altura, 2);
            imc = peso / altura;

            Console.WriteLine("Seu IMC é :" + imc);
            Console.ReadLine();
        }

        public void Exercicio04()
        {
            /*
             * Efetuar o cálculo da quantidade de litros de 
             * combustível gasta em uma viagem, utilizando 
             * um automóvel que faz 12 Km por litro. 
             */
            float tempo, velocidade, distancia, litrosUsados;
            string perguntaTempo = "Quanto tempo demorou a viagem? (Em horas)",
                   perguntaVelocidade = "Qual a velocidade média da viagem? (Em Km/H)";

            Console.WriteLine(perguntaTempo);
            var input = Console.ReadLine().Replace(".", ",");
            tempo = ValidarFloat(perguntaTempo, input);

            Console.WriteLine(perguntaVelocidade);
            input = Console.ReadLine().Replace(".", ",");
            velocidade = ValidarFloat(perguntaVelocidade, input);


        }
    }
}
