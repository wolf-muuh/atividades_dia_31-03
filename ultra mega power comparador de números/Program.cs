// Faça um programa que leia três números e mostre o maior e o menor deles.

// algorítmo
// entrada: número qualquer
// procedimento: comparar os números para saber qual o maior e qual é o menos 

Console.WriteLine($"Digite o 1° número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 2° número: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 3° número: ");
int n3 = int.Parse(Console.ReadLine());

if ((n1 > n2) && (n1 < n3)) {
    Console.WriteLine($"Maior número: {n3}");
    Console.WriteLine($"Menor número: {n2}");
}
else if ((n2 > n1) && (n2 < n3)) {
    Console.WriteLine($"Maior número: {n3}");
    Console.WriteLine($"Menos número: {n1}");
}
else if ((n1 > n2) && (n3 < n2)) {
    Console.WriteLine($"Maior número: {n1}");
    Console.WriteLine($"Menos número: {n3}");
}
else if ((n1 < n2) && (n3 < n1)) {
    Console.WriteLine($"Maior número: {n2}");
    Console.WriteLine($"Menos número: {n3}");
}







