// Serve para printar na tela uma mensagem
//WriteLine escreve uma linha na tela e quebre a linha
Console.WriteLine("Qual é o seu nome: ");
// tipoDaVariavel nomeDaVariavel = valorDaVariavel e ;
string nome = Console.ReadLine()!;
Console.WriteLine($"Muito Prazer {nome}");
// Escreva na mesma linha(Permanece na mesma linha)
Console.Write("Qual é a sua idade:");
int idade = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Seu nome é: {nome} e sua idade é: {idade}");
string terminaTela = Console.ReadLine()!;
// Escreva na mesma linha(Permanece na mesma linha)
// System.Out.Println();