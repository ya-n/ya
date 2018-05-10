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
            Cliente cli = new Aula1005.Cliente();
            cli.Nome = "Conrado"; //set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "12345678901"; //set
            string cpfCliente = cli.Cpf; //get

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);

            Console.ReadKey();
        }
    }
}
