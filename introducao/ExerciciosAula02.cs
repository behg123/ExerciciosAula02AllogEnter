using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02
{
    class ExerciciosAula02
    {

        public float ValidarFloat(String text, String input)
        {
            float outputValue;
            while (!float.TryParse(input, out outputValue))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido, Digite apenas números");
                Console.WriteLine(text + ": " );
                input = Console.ReadLine();
            }
            return outputValue;
        }

        public void Exercicio01()
        {
            /*
             *  Crie um programa que: 
             *      Leia a cotação do dólar
             *      Leia um valor em dólares
             *      Converta esse valor para Real
             *      Mostre o Resultado
             */

            //inicializaçao dos valores
            float cotacao, moeda, real;
            string perguntaCotacao = "Qual a cotacao do dolar?",
                   perguntaDolar = "Valor do dólar a ser convertido";

            //Leitura do valor da cotação do dólar
            Console.WriteLine(perguntaCotacao);
            var input = Console.ReadLine().Replace(".", ",");
            cotacao = ValidarFloat(perguntaCotacao, input);

            //Leitura do valor em dólares
            Console.WriteLine(perguntaDolar);
            input = Console.ReadLine().Replace(".", ",");
            moeda = ValidarFloat(perguntaDolar, input);

            //Conversão do valor para Real
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

            //inicializaçao dos valores
            float celsius, fahrenheit;
            string perguntaCelsius = "Qual a temperatura em Celsius?";


            //Leitura do valor em Celsius
            Console.WriteLine(perguntaCelsius);
            var input = Console.ReadLine().Replace(".", ",");
            celsius = ValidarFloat(perguntaCelsius, input);

            //Conversão de Celsius para Fahrenheit
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
            float tempo, velocidade, distancia, litrosUsados, conversaoVelocidade = 1, conversaoTempo = 1;
            string perguntaTempo = "Quanto tempo demorou a viagem? (Em horas)",
                   perguntaVelocidade = "Qual a velocidade média da viagem? (Em Km/H)";                  ;
            bool numeroValido = false;
            int numero;


            while (!numeroValido)
            {
                Console.WriteLine("Você deseja calcular em KM/H (1), ou M/S (2)");
                if (int.TryParse(Console.ReadLine(), out numero))
                switch (numero)
                {
                    case 1:
                        numeroValido = true;
                        break;
                    case 2:
                        conversaoVelocidade = 3.6f;
                        conversaoTempo = 60f;
                        perguntaTempo = "Quanto tempo demorou a viagem? (Em Segundos)";
                        perguntaVelocidade = "Qual a velocidade média da viagem? (Em M/S)";
                        numeroValido = true;
                        break;
                    default:
                        Console.WriteLine("Número invalido");
                        break;
                }
            }

            Console.WriteLine(perguntaTempo);
            var input = Console.ReadLine().Replace(".", ",");
            tempo = ValidarFloat(perguntaTempo, input) / conversaoTempo;

            Console.WriteLine(perguntaVelocidade);
            input = Console.ReadLine().Replace(".", ",");
            velocidade = ValidarFloat(perguntaVelocidade, input) * conversaoVelocidade;

            distancia = tempo * velocidade;
            litrosUsados = distancia / 12;

            Console.WriteLine("A quantidade de litros utilizados é: " + litrosUsados);
            Console.ReadLine();
        }

        public void Exercicio05()
        {
            /*
             * Crie um programa para ler uma temperatura em graus Fahrenheit 
             * e apresente convertida em graus Celsius. A fórmula de conversão 
             */

            //inicializaçao dos valores
            float celsius, fahrenheit;
            string perguntaFahrenheit = "Qual a temperatura em Fahrenheit?";


            //Leitura do valor em Fahrenheit
            Console.WriteLine(perguntaFahrenheit);
            var input = Console.ReadLine().Replace(".", ",");
            fahrenheit = ValidarFloat(perguntaFahrenheit, input);

            //Conversão de Fahrenheit para Celsius
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("conversão em Celsius:" + celsius + " °C");
            Console.ReadLine();
        }

        public void Exercicio06()
        {
            /* Crie um programa que solicite a entrada de uma frase, 
             * após isto troque todas as letras A ou a por &, 
             * porém não utilize o método Replace().
             */
            string novaFrase = "";
            
            Console.WriteLine("Escreva uma frase");
            var input = Console.ReadLine();


            foreach(char character in input)
            {

                if(character == 'a' || character == 'A')
                {
                    novaFrase += '&';
                } else
                {
                    novaFrase += character;
                }
            }

            Console.WriteLine($"A frase ficaria: {novaFrase}");
            Console.ReadLine();
        }

        public void Exercicio07()
        {
            /* Crie um programa que receba por parâmetro o nome, 
             * e retorne a frase “Olá meu nome é: {nome recebido}”.             
             */

            Console.WriteLine("Qual seu nome?");
            var input = Console.ReadLine();

            Console.WriteLine($"Olá meu nome é: {input}");
            Console.ReadLine();
        }

        public void Exercicio08()
        {
            /* Crie um programa que calcule o reajuste salarial. 
             * Se o salário for abaixo de 1.850 o ajuste é de R$320.00,
             * se maior de R$ 180.00. Para finalizar, exiba o novo salário na tela.
             */
            string perguntaSalario = "Qual seu salário?";
            float salario;

            Console.WriteLine(perguntaSalario);
            var input = Console.ReadLine().Replace(".", ",");
            salario = ValidarFloat(perguntaSalario, input);

            salario = salario >= 1850 ? salario + 180 : salario + 320;

            Console.WriteLine($"O novo salário será R${salario},00");
            Console.ReadLine();
        }
    }
}
