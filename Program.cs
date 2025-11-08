double tamanhoBytes, velocidadeMbps, tempoMin;

Console.Write("Digite o tamanho do arquivo em bytes: ");
tamanhoBytes = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a velocidade da conexão em Mbps: ");
velocidadeMbps = Convert.ToDouble(Console.ReadLine());
tempoMin = tamanhoBytes * 8 / velocidadeMbps / 60;
Console.WriteLine($"O tempoestimado para o donwload é de {tempoMin:F2} minutos.");

