using ConsoleApp8;

Estado esta = new Estado();
Cidade _cidade;
Console.WriteLine("Digite a quantidade de cidades a serem adicionadas");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    _cidade = new Cidade();
    Console.WriteLine("Digite o nome da cidade que deseja adicionar: ");
    _cidade.Nome = Console.ReadLine();
    Console.WriteLine("Digite a população da cidade adicionada: ");
    _cidade.Populacao = int.Parse(Console.ReadLine());
    esta.CadrastarCidade(_cidade);
}
Console.WriteLine();
esta.ImprimirCidade();
esta.LocalizarCidadeMaiorPopulacao();

Console.ReadLine();

