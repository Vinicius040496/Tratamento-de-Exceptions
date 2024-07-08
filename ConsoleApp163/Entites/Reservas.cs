using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp163.Entites.Exception;

namespace ConsoleApp163.Entites
{
    internal class Reservas
    {
        public int NumeroQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reservas()
        {

        }

        public Reservas(int numeroQuarto, DateTime entrada, DateTime saida)
        {
            if (saida < entrada)
            {
                throw new DominioException("Erro, data de saida precisa ser posterior a data de entrada!");
            }
            NumeroQuarto = numeroQuarto;
            Entrada = entrada;
            Saida = saida;
        }

        public int Duracao()
        {
            TimeSpan duração = Saida.Subtract(Entrada);
            return (int)duração.TotalDays;
        }
        public void AtualizarDados(DateTime novaentrada , DateTime novasaida)
        {
            DateTime now = DateTime.Now;

            if (novasaida < novaentrada)
            {
                throw new DominioException("Erro, nova data de agendamento precisa se posterior a antiga reserva!!");
            }if (novaentrada < now || novasaida < now)
            {
                throw new DominioException("Não é possivel atualizar datas passadas, necessita de datas futuras!!");
            }

            Entrada = novaentrada;
            Saida= novasaida;
                
        }
     
        public override string ToString()
        {
            return "Quarto: " + NumeroQuarto + ", " + "Data de entrada: " + Entrada.ToString("dd/MM/yyyy")
                + ", " + "Data de saida: " + Saida.ToString("dd/MM/yyyy") + ", " + Duracao().ToString()
                + " Noites ";
        }
    }
}