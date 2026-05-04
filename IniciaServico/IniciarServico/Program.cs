using System.ServiceProcess;

Console.WriteLine("(c) 2025 - WILLIAN SISTEMAS DE INFORMAÇÃO");
Console.WriteLine("WN IniciaServiço");
Console.WriteLine();


//ler arquivo txt com os serviços que devem ser iniciados
//o arquivo deve separar os dados por ponto e virgula(;)
string caminhoArquivo = "servicos.txt";

if(File.Exists(caminhoArquivo))
{
    using StreamReader leitor = new(caminhoArquivo);
    string linha;
    while ((linha = leitor.ReadLine()!) != null)
    {
        string[] colunas = linha.Split(";");
        IniciarServico($"{colunas[0]}");
        Console.WriteLine();
    }
}
else
    Console.WriteLine("Arquivo não encontrado!");

Console.WriteLine("Aguardando 1 minuto antes de encerrar automaticamente...");
await Task.Delay(TimeSpan.FromMinutes(1));

Console.WriteLine("Encerrando o programa...");
Environment.Exit(0);

static void IniciarServico(string nomeServico)
{
    try
    {
        ServiceController sc = new(nomeServico);

        if (sc.Status == ServiceControllerStatus.Stopped)
        {
            sc.Start();
            sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
            Console.WriteLine($"Serviço '{nomeServico}' iniciado com sucesso.");
        }
        else
        {
            Console.WriteLine($"Serviço '{nomeServico}' já está em execução.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao iniciar o serviço '{nomeServico}': {ex.Message}");
    }
}
