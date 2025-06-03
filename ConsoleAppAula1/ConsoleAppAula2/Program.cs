//Se o aluno tiver mais que 3 faltas rodou

//Se a nota do aluno for menor que 60 rodou tbm

#region Estrutura de repetição

/* 
string opcao;
int nota;
int faltas;
string nome;

while (true)
{
    Console.WriteLine("Informe o nome do aluno");
    nome = Console.ReadLine();

    Console.WriteLine("Informe a nota do aluno");
    nota = Convert.ToInt32((Console.ReadLine()));

    Console.WriteLine("Informe o numero de faltas do aluno");
    faltas = Convert.ToInt32((Console.ReadLine()));

    if (nota >= 60 && faltas <= 3)
    {
        Console.WriteLine($"O aluno {nome} está aprovado!");
    }
    else
    {
        Console.WriteLine($"O aluno {nome} está reprovado!");
    }

    Console.WriteLine("Deseja continuar s/n");
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        break;
    }
    else { Console.Clear(); }
}
*/

#endregion

#region Tabuada
/*

int contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada: ");
tabuada = Convert.ToInt32(Console.ReadLine());

for (contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($" {tabuada} X {contador}: {tabuada * contador}");
}
*/
#endregion

#region Contador
/*
int contador = 0;
while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do
{
    Console.WriteLine();
    contador++;
}
while (contador < 10);
*/
#endregion

#region Arrays

/*
string[] nomes = { "Abacaxi", "Maçã", "Banana" };
int[] numeros = { 0, 1, 2, 3, 4, 5 };
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

foreach (int i in numeros)
{
    Console.WriteLine(numeros[i]);
}


Console.ReadKey();
*/
#endregion

#region Booleano
/*
int idadeAluno;
bool MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return true;
    } else
    {
        return false;
    }
}

Console.WriteLine("Informe sua idade: ");
idadeAluno = Convert.ToInt32(Console.ReadLine());

if (MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de idade");
}
else
{
    Console.WriteLine("Aluno menor de idade");
}

MaiorDeIdade(20);


void MaiorDeIdade2(int idade)
{
    if (idade >= 18)
    {
        Console.WriteLine("Aluno maior de idade");
    }
    else
    {
        Console.WriteLine("Aluno menor de idade");
    }
}

MaiorDeIdade2(25);
*/
#endregion

#region
/*
//Função para somar do tipo void
//Função que retorne a multiplicação Resultado int

void Soma(int num1, int num2)
{
    Console.WriteLine(num1 + num2);
}

Soma(1, 2);

int Multiplicacao(int num1, int num2)
{
    return num1 * num2;

}

int resultado = Multiplicacao(5, 2);

Console.WriteLine(resultado);

*/
#endregion

