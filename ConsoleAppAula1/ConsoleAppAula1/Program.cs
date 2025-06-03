/* IF IDADE
int idade;
Console.WriteLine("Informe sua idade!");

idade = Convert.ToInt32(
    Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine($"Sua idade é {idade}");
}
else
{
    Console.WriteLine($"Você é menor de idade");
}
*/

/* IF SALÁRIO
Salário minimo ou salário comum

const decimal salarioMinimo = 1518m;

Console.WriteLine("Informe seu salário");

decimal salarioPessoal = decimal.Parse(Console.ReadLine());

if (salarioPessoal == salarioMinimo)
{
    Console.WriteLine($"Voce recebe UM salário minimo. {salarioPessoal:C}");
}
else if (salarioPessoal < salarioMinimo)
{
    Console.WriteLine($"Voce recebe menos que um salário minimo. {salarioPessoal:C}");
}
else
{
    Console.WriteLine($"Voce recebe mais que um salário minimo ({salarioMinimo:C}). {salarioPessoal:C}");
}
*/

/* Informar operação matemática
float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;


Console.WriteLine("Informe a operação matemática:\n" +
    "+ ou - ou * ou /");
operacaoMatematica = Console.ReadLine();


Console.WriteLine("Informe o primeiro valor");
num1 = float.Parse(Console.ReadLine());


Console.WriteLine("Informe o segundo valor");
num2 = float.Parse(Console.ReadLine());

if(operacaoMatematica == "+")
{
    Console.WriteLine($"Soma: {(num1 + num2):F2}");
} else if (operacaoMatematica == "-")
{
    Console.WriteLine($"Subração: {(num1 - num2):F2}");
} else if (operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
} else if (operacaoMatematica == "/")
{
    Console.WriteLine($"Multiplicação: {(num1 /  num2):F2}");
} else
{
    Console.WriteLine("Algo deu errado, digite apenas o sinal da operação");
}
*/

float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;
string opcao; 


while (true)
{
    Console.WriteLine("Informe a operação matemática:\n" +
        "+ ou - ou * ou /");
    operacaoMatematica = Console.ReadLine();


    Console.WriteLine("Informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());


    Console.WriteLine("Informe o segundo valor");
    num2 = float.Parse(Console.ReadLine());

    switch (operacaoMatematica)
    {
        case "+":
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;
        case "-":
            Console.WriteLine($"Subração: {(num1 - num2):F2}");
            break;
        case "*":
            Console.WriteLine($"Multiplicação: {(num1 * num2):F2}");
            break;
        case "/":
            Console.WriteLine($"Multiplicação: {(num1 / num2):F2}");
            break;

        default:
            Console.WriteLine("Algo deu errado, digite apenas o sinal da operação");
            break;
    }

    Console.WriteLine("Deseja continuar s/n");
    opcao = Console.ReadLine();

    if ( opcao != "s" )
    {
        break;
    } else { Console.Clear(); }
}


