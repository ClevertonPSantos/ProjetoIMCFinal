using System;

namespace ProjetoIMCFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro vamos criar as variáveis
            string nome;
            string sexo;
            int idade;
            double altura, peso, resultAltura;
            
            
            Console.WriteLine("\nSeja bem vindo(a), irei conhecer um pouco melhor você. Vamos começar!!!");

            //Pedir os dados iniciais
            Console.WriteLine("\nQual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("\nTudo bem " + nome +", vamos continuar...");

            Console.WriteLine("\nQual o seu sexo, masculino ou feminino?");
            sexo = Console.ReadLine();
            Console.WriteLine("\nSabemos agora que você é do sexo " + sexo);
           
            Console.WriteLine("\nQual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nOk " + nome + ", já anotamos a sua idade de " + idade + " anos");

            Console.WriteLine("\nQual a sua altura?");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nOk " + nome + ", agora sabemos que sua altura é " + altura);

            Console.WriteLine("\nQual o seu peso atual?");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEstamos te conhecendo melhor " + nome + ".");

            Console.WriteLine("\n"+ nome + ", Agora temos os seguintes dados seu:");
            Console.WriteLine("\nVocê é do sexo " + sexo + ", você tem " + idade + " anos, a sua altura é " + altura + " e seu peso é " + peso + "Kg.");

            //calculos do IMC

            resultAltura = altura * altura;
            double imc;
            imc = peso / resultAltura;

            
            Console.WriteLine("\nSeu IMC é: " + Math.Round(imc, 2).ToString());

            //Aqui vamos ver em qual das opções o IMC se encontra
            if (imc <= 18)
                Console.WriteLine("O seu IMC está abaixo do normal");

            if (imc > 18 && imc <= 25)
                Console.WriteLine("O seu IMC está normal.");

            if (imc > 25 && imc <= 30)
                Console.WriteLine("O seu IMC está acima do normal.");

            if (imc > 30 && imc <= 35)
                Console.WriteLine("O seu IMC está bem acima do normal, é recomendado você procurar ajuda medica.");

            if (imc > 35 && imc <= 40)
                Console.WriteLine("O seu IMC está muito acima do esperado, procure ajuda médica.");

            if (imc > 40)
                Console.WriteLine("O seu IMC está MUITO ACIMA do esperado, por favor procure um médico urgente.");
        }
    }
}
