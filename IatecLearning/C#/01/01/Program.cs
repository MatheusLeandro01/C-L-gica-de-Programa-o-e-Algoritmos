string[] nomes = new string[3]; //criando array de 3 posições
nomes[0] = "Matheus"; //adicionando uma string na posição 0
nomes[1] = "Marcos"; //adicionando uma string na posição 1
nomes[2] = "João"; //adicionando uma string na posição 2

Console.WriteLine(nomes[2]); //Imprime o valor
Console.WriteLine(nomes.Length); //Mostra o tamanho do array
Console.WriteLine(nomes.First()); // Aparece o primeiro valor
Console.WriteLine(nomes.Last()); // Aparece o último valor
Console.WriteLine(nomes.ElementAt(2)); //Método para mostrar o valor colocado como parâmetro
Console.WriteLine(nomes.Any()); //verifica se possui algum elemento -> retorna valor bool

var nomes2 = nomes.Append("Lucas");

var tudo = nomes.Concat(nomes2); // estamos concatenando nomes e nomes2


// foreach está percorrendo as posições de nomes2
foreach (string item in nomes2) //para cada item contido em nomes2
{
    Console.WriteLine(item); //imprime item
}