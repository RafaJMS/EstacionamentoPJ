using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaJá
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void adicionarVeiculo()
        {
            Console.Write("Insira a placa do veiculo que vai ser adicionado: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(X => X.Equals(placa)))
            {
                Console.WriteLine("Essa placa já está cadastrada. Insira uma válida!");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo cadastrado! Bem vindo ao EstacionaJá!");
            }
        }

        public void removerVeiculo()
        {
            Console.Write("Insira a placa do veiculo que vai ser removido: ");
            string placa = Console.ReadLine();


            if (veiculos.Any(x => x.Equals(placa)))
            {
                Console.Write("Insira a quantidade de horas permanecidas no pátio: ");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                
                decimal precoTotal = precoInicial + precoHora * horas;
                
                Console.WriteLine("Placa: " + placa);
                Console.WriteLine("Horas: " + horas);
                Console.WriteLine("Preço Hora: " + precoHora);
                Console.WriteLine("Preço Fixo: " + precoInicial);
                Console.WriteLine("Total: " + precoTotal);

                veiculos.Remove(placa);
                Console.WriteLine("Veiculo removido. Volte sempre!");
                
            }
            else
            {
                Console.WriteLine("Essa placa não se encontra no estacionamento. Insira uma válida!");
            }
        }

        public void listarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são");
                foreach (var item in veiculos)
                {
                    Console.WriteLine("Placa: " + item);
                }
            }else 
            {
                Console.WriteLine("Não há veiculos estacionados!");
            }
        }
    }
}
