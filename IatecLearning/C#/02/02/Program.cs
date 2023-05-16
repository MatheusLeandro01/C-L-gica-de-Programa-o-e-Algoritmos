List<string> nomes = new List<string>(); //Criando uma lista de string
nomes.Add("Matheus"); //método Add para adicionar um item na lista
nomes.Add("Marcos");
nomes.Add("Lucas");

nomes.RemoveAt(2); //Método para remover item (posição é passada como parâmetro) 

Console.WriteLine(nomes.Count); //propriedade para contar valores

nomes.Clear(); //limpou a lista



List<string> nomes2 = new List<string>();
nomes.Add("João");
nomes.Add("Tito");
nomes.Add("Felipe");

nomes.AddRange(nomes2); //concatenamos as duas listas

foreach (var item in nomes)
{
    Console.WriteLine(item);
}