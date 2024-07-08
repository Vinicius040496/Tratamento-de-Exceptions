using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp163.Entites;
using ConsoleApp163.Entites.Exception;

namespace ConsoleApp163
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de entrada (dd/mm/yyyy): ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saida (dd/mm/yyyy): ");
                DateTime saida = DateTime.Parse(Console.ReadLine());

                Reservas reservas = new Reservas(numeroQuarto, entrada, saida);
                Console.WriteLine(reservas);

                Console.WriteLine();
                Console.WriteLine("Entre com dados para atualizar a reserva: ");
                Console.Write("Data de entrada (dd/mm/yyyy): ");
                DateTime novaentrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saida (dd/mm/yyyy): ");
                DateTime novasaida = DateTime.Parse(Console.ReadLine());

                reservas.AtualizarDados(novaentrada, novasaida);
                Console.WriteLine(reservas);

            }
            catch (DominioException e)
            {
                Console.WriteLine("Erro na reserva" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado!" + e.Message);
            }
            Console.ReadLine();


        }
    }
}

