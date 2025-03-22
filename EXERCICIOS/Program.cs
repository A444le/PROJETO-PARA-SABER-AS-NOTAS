//questao 1

//string[] nomes = new string[5];

//nomes[0] = "ciclano";
//nomes[1] = "fulano";
//nomes[2] = "Ditano";
//nomes[3] = "camaleao";
//nomes[4] = "zebra";

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine(nomes[i]);

//}


//questao 2


int[] numeros = new int[5];

int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("informe o numero");
    numeros[i] = int.Parse(Console.ReadLine());
    soma = soma + numeros[i];
}
Console.WriteLine(soma);

//questao 3


//int[] novosnumeros = [2, 6, 9, 18, 10];
//int maiornumero = 0;

//for (int i = 0; i < novosnumeros.Length; i++)
//{
//    if (novosnumeros[i] > maiornumero) 
//    { 
//    maiornumero=novosnumeros[i];
//    }
//}

//Console.WriteLine(maiornumero);


