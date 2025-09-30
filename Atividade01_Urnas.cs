using System;

class Atividade01_Urnas
{
    public static object MessageBox { get; private set; }

    [STAThread]
    static void Main()
    {

        int votosMSDN = 0;
        int votosTechNet = 0;
        int votosSpoke = 0;
        int votosBranco = 0;
        int votosNulo = 0;
        int totalEleitores = 0;

        string continuar = "sim";

        Console.WriteLine("Data e hora atuais: " + DateTime.Now);
        Console.WriteLine("Vote certo!");

        while (continuar.ToLower() == "sim")
        {
            Console.WriteLine("\nEscolha sua opção de voto:");
            Console.WriteLine("1 - MSDN Brasil");
            Console.WriteLine("2 - TechNet Brasil");
            Console.WriteLine("3 - The Spoke .Net");
            Console.WriteLine("4 - Voto em branco");
            Console.WriteLine("5 - Voto nulo");

            Console.Write("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    votosMSDN++;
                    break;
                case 2:
                    votosTechNet++;
                    break;
                case 3:
                    votosSpoke++;
                    break;
                case 4:
                    votosBranco++;
                    break;
                case 5:
                    votosNulo++;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Voto não registrado.");
                    continue;
            }

            totalEleitores++;

            Console.Write("Deseja continuar votando? (sim/não): ");
            continuar = Console.ReadLine();
        }

        string resultado = $"RESULTADO FINAL:\n\n" +
                           $"MSDN Brasil: {votosMSDN} votos\n" +
                           $"TechNet Brasil: {votosTechNet} votos\n" +
                           $"The Spoke .Net: {votosSpoke} votos\n" +
                           $"Votos em branco: {votosBranco}\n" +
                           $"Votos nulos: {votosNulo}\n\n" +
                           $"Total de eleitores: {totalEleitores}";

        MessageBox.Show(resultado, "Urna Eletrônica");
    }
}
