﻿using System;

namespace ProjetoIMCFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro vamos criar as variáveis
            string nome;
            string sexo;
            string categoria;
            int idade;
            double altura, peso, resultAltura;
            bool verificar = false;
            
            Console.WriteLine("\nSeja bem vindo(a), irei conhecer um pouco melhor você. Vamos começar!!!");

            //Pedir os dados iniciais
            Console.WriteLine("\nQual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("\nTudo bem " + nome +", vamos continuar...");

            Console.WriteLine("\nQual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nOk " + nome + ", já anotamos a sua idade de " + idade + " anos");

            Console.WriteLine("\nQual a sua altura?");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Ok " + nome + ", agora sabemos que sua altura é " + altura);


        }
    }
}
