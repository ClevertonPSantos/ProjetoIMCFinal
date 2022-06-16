using System;

namespace ProjetoIMCFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro vamos criar as variáveis
            string nome = "";
            string sexo = "";
            double idade = 0;
            double altura = 0;
            double peso = 0;
            double resultAltura;
            string categoria = "";
            string sexodefinido = "";


            Console.WriteLine("\nSeja bem vindo(a), irei conhecer um pouco melhor você. Vamos começar!!!");

            //Pedir os dados iniciais e fazer as validações 
            //Foi usado o IsNullWhiteSpace para evitar que o usuário entre com espaço ou campo vazio
            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("\nQual o seu nome: ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite um nome válido");
                }
            }

            //Foi usado o IsNullWhiteSpace para evitar que o usuário entre com espaço ou campo vazio
            while (string.IsNullOrWhiteSpace(sexo))
            {
                Console.Write("\nDigite seu sexo M (masculino) ou F (feminino): ");
                sexo = Console.ReadLine();

                if ((sexo == "m") && (sexo == "M"))
                {
                    sexodefinido = "Masculino";
                }
                if ((sexo == "f") && (sexo == "F"))
                {
                    sexodefinido = "Feminino";
                }

            }

            //Aqui eu usei o TryParse para que se for usado espaço ou campo vazio retorne e faça a pergunta novamente
            while (idade <= 0)
            {
                Console.Write("\nDigite a sua idade: ");
                double.TryParse(Console.ReadLine(), out idade);
                if (idade <= 0)
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }

            //
            while (altura <= 0)
            {
                Console.Write("\nDigite a sua altura: ");
                double.TryParse(Console.ReadLine().Replace(".",","), out altura);
                if (altura <= 0)
                {
                    Console.WriteLine("Digite um valor válido");
                }

            }

            while (peso <= 0)
            {
                Console.Write("\nDigite o seu peso atual: ");
                double.TryParse(Console.ReadLine().Replace(".",","), out peso);
                if (peso <= 0)
                {
                    Console.WriteLine("Digite um valor válido");
                }

            }


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

            Console.WriteLine("DIAGNÓSTICO PRÉVIO");
            Console.WriteLine("\nNome: " + nome + "\nSexo: " + sexodefinido + "\nIdade: " + idade + " anos \nAltura: " + altura +
                 " m \nPeso: " + peso + " Kg \nCategoria: " + categoria);

            //calculos do IMC

            resultAltura = altura * altura;
            double imc;
            imc = peso / resultAltura;

            Console.WriteLine("IMC Desejável: entre 20 e 24");
            Console.WriteLine("\nSeu IMC é: " + Math.Round(imc, 2).ToString() + "\n");


            //Aqui vamos ver em qual das opções o IMC se encontra, riscos e indicações

            //Caso o imc da pessoa for menor que 20 ele entra nesse if, se não entra no proximo
            if (imc < 20)
            {
                Console.WriteLine("\nO seu IMC está abaixo do normal.\n\nRiscos para sua saúde:\nMuitas complicações de saúde como doenças pulmonares e " +
                    "cardiovasculares podem estar associados ao baixo peso.\n\nRecomendação inicial:\nInclua carboidratos simples em sua dieta," +
                    "além de proteínas indispensáveis para ganho de massa magra.\nProcure um profissional.");

            }

            //Caso imc da pessoa de maior ou igual 20 e menor ou igual a 24 ele entra nesse if, se não entra no proximo
            if (imc >= 20 && imc <= 24)
            {
                Console.WriteLine("\nO seu IMC encontra-se normal.\n\nRiscos para sua saúde:\nSeu peso está ideal para suas referências." +
                    "\n\nRecomendação inicial:\nMantenha uma dieta saudável e faça seus exames periódicos");

            }

            //Caso imc da pessoa de maior que 24 e menor que 30 ele entra nesse if, se não entra no proximo
            if (imc > 24 && imc < 30)
            {
                Console.WriteLine("\nO seu IMC encontra-se acima do normal.\n\nRiscos para sua saúde:\nAumento de peso" +
                    " apresenta risco moderado para outras doenças crônicas e cardiovasculares.\n\nRecomendação inicial:" +
                    "\nAdote um tratamento baseado em dieta balanceada, exercício físico e medicação." +
                    "\nA ajuda de um profissional pode ser interessante.");

            }

            //Caso imc da pessoa seja maior ou igual a 30 ele entra nesse if, se não entra no proximo
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
