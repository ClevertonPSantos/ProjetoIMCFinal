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
            int idade = 0;
            double altura = 0;
            double peso = 0;
            double resultAltura;
            string categoria = "";


            Console.WriteLine("\n--------- Seja bem vindo(a) ---------\n");
            Console.WriteLine(" Para começar o cálculo do seu IMC precisaremos dos dados pedidos abaixo\n\n");

            //Pedir os dados iniciais e fazer as validações 
            //Foi usado o IsNullWhiteSpace para evitar que o usuário entre com espaço ou campo vazio
            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.Write("\n Qual o seu nome: ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine(" Digite um nome válido");
                }
            }

            //Foi usado o IsNullWhiteSpace para evitar que o usuário entre com espaço ou campo vazio
            //Foi usado o ToLower para que o usuário possa digitar o valor em maiúscula ou minúscula e ser recebido
            while (string.IsNullOrWhiteSpace(sexo) || sexo.ToLower() != "m" && sexo.ToLower() != "f")
            {
                Console.Write("\n Digite seu sexo M para (masculino) ou F para (feminino): ");
                sexo = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(sexo))
                {
                    Console.WriteLine(" Digite um valor válido");
                }
                if(sexo.ToLower() == "m")
                {
                    sexo = "Masculino";
                    break;
                }
                if(sexo.ToLower() == "f")
                {
                    sexo = "Feminino";
                    break;
                }
            }

            //Aqui eu usei o TryParse para que se for usado espaço ou campo vazio retorne e faça a pergunta novamente
            while (idade <= 0 || idade > 130)
            {
                Console.Write("\n Digite a sua idade: ");
                int.TryParse(Console.ReadLine(), out idade);
                if(idade <= 0)
                {
                    Console.WriteLine(" Digite um valor válido");
                }
                if(idade > 130)
                {
                    Console.WriteLine(" Digite um valor válido");
                }
                
            }

            //Aqui eu usei o TryParse para que se for usado espaço ou campo vazio retorne e faça a pergunta novamente
            //Utilizei Replace para caso o usuário use o ponto entre os valores ele passe a usar vírgula
            while (altura <= 0 || altura > 2.60)
            {
                Console.Write("\n Digite a sua altura: ");
                double.TryParse(Console.ReadLine().Replace(".",","), out altura);
                if(altura <= 0)
                {
                    Console.WriteLine(" Digite um valor válido");
                }
                if(altura > 2.60)
                {
                    Console.WriteLine(" Digite um valor válido");
                }

            }
            //Aqui eu usei o TryParse para que se for usado espaço ou campo vazio retorne e faça a pergunta novamente
            //Utilizei Replace para caso o usuário use o ponto entre os valores ele passe a usar vírgula
            while (peso <= 0 || peso > 600)
            {
                Console.Write("\n Digite o seu peso atual: ");
                double.TryParse(Console.ReadLine().Replace(".",","), out peso);
                if (peso <= 0)
                {
                    Console.WriteLine(" Digite um valor válido");
                }
                if(peso > 600)
                {
                    Console.WriteLine(" Digite um valor válido");
                }

            }


            //Aqui vamos ver em qual categoria a pessoa se enquadra conforme a sua idade

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

            //Aqui sera impresso todos os dados coletados anteriormente
            Console.WriteLine("--------- DIAGNÓSTICO PRÉVIO ---------");
            Console.WriteLine("\n Nome: " + nome + "\n Sexo: " + sexo + "\n Idade: " + idade + " anos \n Altura: " + altura +
                 " m \n Peso: " + peso + " Kg \n Categoria: " + categoria);

            //calculos do IMC

            resultAltura = altura * altura;
            double imc;
            imc = peso / resultAltura;

            //Depois que for feito o calculo ele vai imprimir o valor com 2 casas após a vírgula
            Console.WriteLine("\n IMC Desejável: entre 20 e 24");
            Console.WriteLine("\n Seu IMC é: " + Math.Round(imc, 2).ToString() + "\n");


            //Aqui vamos ver em qual das opções o IMC se encontra, sugerindo os riscos e recomendações

            //Caso o imc da pessoa for menor que 20 ele entra nesse if, se não entra no proximo
            if (imc < 20)
            {
                Console.WriteLine("\n O seu IMC está abaixo do normal.\n\n Riscos para sua saúde:\n Muitas complicações de saúde como doenças pulmonares e " +
                    "cardiovasculares podem estar associados ao baixo peso.\n\n Recomendação inicial:\n Inclua carboidratos simples em sua dieta," +
                    "além de proteínas indispensáveis para ganho de massa magra.\n Procure um profissional.");

            }

            //Caso imc da pessoa de maior ou igual 20 e menor ou igual a 24 ele entra nesse if, se não entra no proximo
            if (imc >= 20 && imc <= 24)
            {
                Console.WriteLine("\n O seu IMC encontra-se normal.\n\n Riscos para sua saúde:\n Seu peso está ideal para suas referências." +
                    "\n\n Recomendação inicial:\n Mantenha uma dieta saudável e faça seus exames periódicos");

            }

            //Caso imc da pessoa de maior que 24 e menor que 30 ele entra nesse if, se não entra no proximo
            if (imc > 24 && imc < 30)
            {
                Console.WriteLine("\n O seu IMC encontra-se acima do normal.\n\n Riscos para sua saúde:\n Aumento de peso" +
                    " apresenta risco moderado para outras doenças crônicas e cardiovasculares.\n\n Recomendação inicial:" +
                    "\n Adote um tratamento baseado em dieta balanceada, exercício físico e medicação." +
                    "\n A ajuda de um profissional pode ser interessante.");

            }

            //Caso imc da pessoa seja maior ou igual a 30 e menor que 35 ele entra nesse if, se não entra no proximo
            if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("\n O seu IMC encontra-se bem acima do normal.\n\n Riscos para sua saúde:\n Quem tem obesidade vai " +
                    "estar mais exposto a doenças graves e ao risco de mortalidade.\n\n Recomendação inicial:\n" +
                    " Adote uma dieta alimentar rigorosa, com acompanhamento de um nutricionista e um médico especialista (endócrino).");

            }
            //Caso imc da pessoa seja maior ou igual a 35 ele entra nesse if sendo o último if
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
