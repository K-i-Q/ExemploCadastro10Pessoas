using System;
using System.Collections.Generic;

namespace Cadastro10Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            var listaDeCadastros = new List<Pessoa>();
            var possoRegistrar = true;
            do
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                pessoa.Nome = Console.ReadLine();
                if (string.IsNullOrEmpty(pessoa.Nome))
                {
                    Console.WriteLine("O nome da pessoa não pode ser vazio! ");
                }
                else
                {
                    if (listaDeCadastros.Count > 10)
                    {
                        possoRegistrar = false;
                        Console.WriteLine("Erro! Limite máximo de pessoas atingido!");
                    }
                    else
                    {
                        listaDeCadastros.Add(pessoa);
                    }
                }

            } while (possoRegistrar);
        }
    }
    public class Pessoa
    {
        public Pessoa()
        {
            CadastradoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public DateTime CadastradoEm { get; set; }
    }
}
