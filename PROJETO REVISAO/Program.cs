//vetores 


string[] nomes = new string[15];


//colocar o nome na posicao que deseja 
nomes[0] = "vinicio";
nomes[3] = "fulano";

//FOR vai servir para preencher a lista 
// length siginifica largura - quantidade 
for (int i = 0; i < nomes.Length; i++)
{

    Console.WriteLine("informe o nome:");
    nomes[i] = Console.ReadLine();
}

//como listar no vetor

//1 - listando com FOR 

//i serve para falar sobre todos 





//1 e 2 sao a mesma coisa, so que oq muuda e q um e for e o outro foreach

/for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

//2 - listando com o foreach (para cada)
foreach (var item in nomes)
{
    Console.WriteLine(item);
}
