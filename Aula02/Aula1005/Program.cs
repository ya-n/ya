using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.Nome = "Conrado"; //set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "12345678901"; //set
            string cpfCliente = cli.Cpf; //get

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);

            //Utilizando os contrutores parametrizados
            Cliente cli2 = new Cliente("Yangre"); //nome
            Cliente cli3 = new Cliente("Lelinho", "123"); //nome, cpf


            Console.ReadKey();
        }
    }
}
