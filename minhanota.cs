System.Console.WriteLine("Bem vindo(a) a Calculadora de Média");

System.Console.WriteLine("Insira a Nota 1:");
var nota1 = System.Console.ReadLine();
var nota1conv = Convert.ToDouble(nota1);

System.Console.WriteLine("Insira a Nota 2:");
var nota2 = System.Console.ReadLine();
var nota2conv = Convert.ToDouble(nota2);

System.Console.WriteLine("Insira a Nota 3:");
var nota3 = System.Console.ReadLine();
var nota3conv = Convert.ToDouble(nota3);

double media = (nota1conv + nota2conv + nota3conv) / 3;
System.Console.WriteLine("Sua média final é: " + media);

if (media >= 7)
{
    System.Console.WriteLine("Aprovado(a)");
}
else if (media >= 5 && media < 7)
{
    System.Console.WriteLine("Recuperação");
}
else
{
    System.Console.WriteLine("Reprovado(a)!");
}
System.Console.WriteLine("Obrigado por utilizar o programa de notas!");