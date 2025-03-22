//Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).



//1 - inserir as notas de um aluno 

int[] notas = new int[5];
int soma = 0;

for (int i = 0; i < notas.Length; i++)
{
    Console.Write("INFOME A NOTA: ");
    notas[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine();

{ for (int i = 0; i < notas.Length; i++)
        {
        soma += notas[i];
    }

//2- exibir a nota 

    Console.WriteLine($"A SOMA DAS SUAS NOTAS FOI {soma}");

    //soma e divisao das notas 

}
int divisor = soma / 5;
Console.WriteLine();
Console.WriteLine($"ENTAO SUA MEDIA E {divisor}");
Console.WriteLine();

//3- exibir se foi aprovado ou n

if (divisor >= 7) 
{
    Console.Write("ENTAO VOCE FOI APROVADO");
    int numero = int.Parse(Console.ReadLine());
}
if (divisor <= 7) 
{
    Console.Write("ENTAO VOCE FOI REPROVADO");
    int numero = int.Parse(Console.ReadLine());
}
