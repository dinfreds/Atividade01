// Faça um programa que leia três números, verifique (usando if e else) 
//e mostre o maior e o menor deles;  (Não utilize estrutura de repetição)
int numero1, numero2, numero3, maiorNum = 0, menorNum = 0;

Console.WriteLine("Digite o primeiro numero");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero3 < numero2)
{
    maiorNum = numero1;


}
if (numero2 > numero3 && numero1 < numero2)

{
    maiorNum = numero2;
}
if (numero3 > numero2 && numero1 < numero3)
{
    maiorNum = numero3;
}
else if (numero1 < numero2 && numero3 > numero2)
{
    menorNum = numero1;
}
if (numero2 < numero3 && numero1 > numero2)
{
    menorNum = numero2;
}
if (numero3 < numero2 && numero2 > numero3)
{
    menorNum = numero3;
}



Console.WriteLine("Maior numero e " + maiorNum + " e o menor numero e " + menorNum);