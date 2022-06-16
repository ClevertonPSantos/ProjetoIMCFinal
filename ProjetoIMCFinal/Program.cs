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
            string categoria;
            
            
            Console.WriteLine("\nSeja bem vindo(a), irei conhecer um pouco melhor você. Vamos começar!!!");

            //Pedir os dados iniciais
            Console.WriteLine("\nQual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("\nTudo bem " + nome +", vamos continuar...");

            Console.WriteLine("\nQual é o seu sexo?");
            sexo = Console.ReadLine();

            if ((sexo == "masculino") && (sexo == "Masculino"))
            {
                Console.WriteLine("\nSabemos agora que você é do sexo " + sexo);
            }
            else if ((sexo == "feminino") && (sexo == "Feminino"))
            {
                Console.WriteLine("\nSabemos agora que você é do sexo " + sexo);
            }
            else if ((sexo != "masculino") && (sexo != "feminino") && (sexo != "Masculino") && (sexo != "Feminino"))
            {
                Console.WriteLine("Digite um sexo valido");
            }

            Console.WriteLine("\nQual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nOk " + nome + ", já anotamos a sua idade de " + idade + " anos");

            Console.WriteLine("\nQual a sua altura?");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nOk " + nome + ", agora sabemos que sua altura é " + altura);

            Console.WriteLine("\nQual o seu peso atual?");
            peso = double.Parse(Console.ReadLine());
           
            Console.Clear();

            if (idade < 12)
                Console.WriteLine(nome + "\n, você se econtra na categoria Infantil");

            if (idade >= 12 && idade <= 20)
                Console.WriteLine(nome + "\nVocê se econtra na categoria Juvenil");

            if (idade > 20 && idade <= 65)
                Console.WriteLine(nome + "\nVocê se econtra na categoria Adulto");

            if (idade > 65)
                Console.WriteLine(nome + "\nVocê se econtra na categoria: Idoso");
            
            Console.WriteLine("\n"+ nome + ", Agora temos os seguintes dados seu:");
            Console.WriteLine("\nVocê é do sexo " + sexo + ", você tem " + idade + " anos, a sua altura é " + altura + "m e seu peso é " + peso + "Kg.");


            //calculos do IMC

            resultAltura = altura * altura;
            double imc;
            imc = peso / resultAltura;

            Console.WriteLine("\nSeu IMC é: " + Math.Round(imc, 2).ToString() + "\n");


            //Aqui vamos ver em qual das opções o IMC se encontra
            if (imc < 20)
                Console.WriteLine("\nO seu IMC está abaixo do normal");
                Console.Write("\nRiscos para sua saúde:\nMuitas complicações de saúde como doenças pulmonares e " +
                    "cardiovasculares podem estar associados ao baixo peso\n\n");

            if (imc >= 20 && imc <= 24)
                Console.WriteLine("\nO seu IMC encontra-se normal.");

            if (imc > 24 && imc < 30)
                Console.WriteLine("\nO seu IMC encontra-se acima do normal.");

            if (imc >= 30 && imc < 34)
                Console.WriteLine("\nO seu IMC encontra-se bem acima do normal, é recomendado você procurar ajuda medica.");

            if (imc >= 35)
                Console.WriteLine("\nO seu IMC encontra-se muito acima do esperado, procure ajuda médica.");

            //Aqui vamos ver em qual categoria a pessoa se enquadra

            

            



        }
    }
}
