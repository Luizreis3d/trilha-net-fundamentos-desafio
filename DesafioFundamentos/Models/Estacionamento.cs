namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 8;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo que será estacionado:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"O veículo de placa {placa} foi estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo que será removido:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo de placa {placa} foi removido com sucesso e o preço total do estacionamento foi de: R$ {valorTotal} reais.");
            }
            else
            {
                Console.WriteLine("Desculpe, este veículo não está estacionado neste estabelecimento. A placa do veículo foi digitada corretamente?");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Estes são os veículos aqui estacionados:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados neste momento.");
            }
        }
    }
}
