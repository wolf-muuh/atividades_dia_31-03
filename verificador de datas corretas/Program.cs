// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.


// algoritmo 
// entrada: dia, mês e ano de aniversário do usuário
// procedimento: comparar a data colocada com a data exigida

Console.WriteLine($"Digite o DIA do seu aniversário: ");
int diaAniversario = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o MÊS do seu aniversário: ");
int mesAniversario = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ANO do seu aniversário: ");
int anoAniversário = int.Parse(Console.ReadLine());

if (diaAniversario > 31){
    Console.WriteLine($"INVÁLIDO");
}
else if (mesAniversario > 12) {
    Console.WriteLine($"INVÁLIDO");
}
else if (anoAniversário > 2013) {
    Console.WriteLine($"INVÁLIDO");
}
else {
    Console.WriteLine($"VÁLIDO");
}





