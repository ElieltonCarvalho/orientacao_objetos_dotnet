// See https://aka.ms/new-console-template for more information
using System;

namespace _01conceitos
{

    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar objeto

            Pessoa obj = new Pessoa();

            obj.nome ="Elielton";
            obj.idade = 24;

            obj.mensagem();

        }
    }
}
