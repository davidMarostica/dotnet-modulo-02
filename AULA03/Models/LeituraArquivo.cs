namespace AULA03.Models
{
    public class LeituraAquivo
    {
        public (bool Success, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}