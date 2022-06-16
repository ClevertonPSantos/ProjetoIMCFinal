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
            string categoria = "";
            
            
            Console.WriteLine("\nSeja bem vindo(a), irei conhecer um pouco melhor você. Vamos começar!!!");

            //Pedir os dados iniciais e fazer as validações
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

            Console.WriteLine("\nQual a sua altura?");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o seu peso atual?");
            peso = double.Parse(Console.ReadLine());


            //Aqui vamos ver em qual categoria a pessoa se enquadra

            if (idade < 12)
            {
                categoria = "Infantil";
            }
            if (idade >= 12 && idade <= 20)
            {
                categoria = "Juvenil";
            }
            if (idade > 20 && idade <= 65)
            {
                categoria = "Adulto";
            }
            if (idade > 65)
            {
                categoria = "Idoso";
            }
            Console.Clear();

            Console.WriteLine("\nDIAGNÓSTICO PRÉVIO");
            Console.WriteLine("\nNome: " + nome + "\nSexo: " + sexo + "\nIdade: " + idade + " anos \nAltura: " + altura +
                 " m \nPeso: " + peso + " Kg \nCategoria: " + categoria);

            //calculos do IMC

            resultAltura = altura * altura;
            double imc;
            imc = peso / resultAltura;

            Console.WriteLine("IMC Desejável: entre 20 e 24");
            Console.WriteLine("\nSeu IMC é: " + Math.Round(imc, 2).ToString() + "\n");


            //Aqui vamos ver em qual das opções o IMC se encontra, riscos e indicações
            if (imc < 20)
            {
                Console.WriteLine("\nO seu IMC está abaixo do normal.\n\nRiscos para sua saúde:\nMuitas complicações de saúde como doenças pulmonares e " +
                    "cardiovasculares podem estar associados ao baixo peso.\n\nRecomendação inicial:\nInclua carboidratos simples em sua dieta," +
                    "além de proteínas indispensáveis para ganho de massa magra.\nProcure um profissional.");

            }

            if (imc >= 20 && imc <= 24)
            {
                Console.WriteLine("\nO seu IMC encontra-se normal.\n\nRiscos para sua saúde:\nSeu peso está ideal para suas referências." +
                    "\n\nRecomendação inicial:\nMantenha uma dieta saudável e faça seus exames periódicos");

            }

            if (imc > 24 && imc < 30)
            {
                Console.WriteLine("\nO seu IMC encontra-se acima do normal.\n\nRiscos para sua saúde:\nAumento de peso" +
                    " apresenta risco moderado para outras doenças crônicas e cardiovasculares.\n\nRecomendação inicial:" +
                    "\nAdote um tratamento baseado em dieta balanceada, exercício físico e medicação." +
                    "\nA ajuda de um profissional pode ser interessante.");

            }

            if (imc >= 30 && imc < 34)
            {
                Console.WriteLine("\nO seu IMC encontra-se bem acima do normal.\n\nRiscos para sua saúde:\nQuem tem obesidade vai " +
                    "estar mais exposto a doenças graves e ao risco de mortalidade.\n\nRecomendação inicial:\n" +
                    "Adote uma dieta alimentar rigorosa, com acompanhamento de um nutricionista e um médico especialista (endócrino).");

            }
            if (imc >= 35)
            {
                Console.WriteLine("\nO seu IMC encontra-se muito acima do esperado.\n\nRiscos para sua saúde:\nO obeso mórbido" +
                    " vive menos, tem alto risco de mortalidade geral por diversas causas.\n\nRecomendação inicial:\n" +
                    "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar,\n" +
                    "um psícologo e um médico especialista (endócrino).");

            }

            

            



        }
    }
}
