//Atividade_01: Entrada em balada
int idade;
Console.WriteLine("Digite sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char sexo;
Console.WriteLine("Digite seu sexo (m/f): ");
char.TryParse(Console.ReadLine().ToUpper(), out sexo);

char Ingresso;
Console.WriteLine("Você possui ingresso? (s/n): ");
char.TryParse(Console.ReadLine().ToUpper(), out Ingresso);

if ((Ingresso == 'S' && idade >= 18) || (sexo == 'F' && idade >= 18))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, você pode entrar na festa!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desculpe, você não pode entrar na festa.");
}


Console.ForegroundColor = ConsoleColor.White;


//Atividade_02: Desconto no cinema
Console.WriteLine("Digite sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char estudante;
Console.WriteLine("Você é estudante? (s/n): ");
char.TryParse(Console.ReadLine().ToUpper(), out estudante);

if (idade <= 12 || estudante == 'S' || idade >= 60)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você paga a meia entrada!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você paga a entrada inteira.");
}


Console.ForegroundColor = ConsoleColor.White;


//Atividade_03: Acesso ao jogo online
Console.WriteLine("Digite sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char assinatura;
Console.WriteLine("Você possui assinatura premium? (s/n): ");
char.TryParse(Console.ReadLine().ToUpper(), out assinatura);

if ((assinatura == 'S' && idade >= 16) || (assinatura == 'N' && idade <= 18))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você pode acessar o jogo online!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desculpe, você não pode acessar o jogo online.");
}



Console.ForegroundColor = ConsoleColor.White;


//Atividade_04: Aprovado, Recuperação ou Reprovado
int nota1, nota2, nota3;
Console.WriteLine("Digite sua primeira nota: ");
int.TryParse(Console.ReadLine(), out nota1);

Console.WriteLine("Digite sua segunda nota: ");
int.TryParse(Console.ReadLine(), out nota2);

Console.WriteLine("Digite sua terceira nota: ");
int.TryParse(Console.ReadLine(), out nota3);

int resultado = (nota1 + nota2 + nota3) / 3;

if (resultado >= 7)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Aluno aprovado.");
}
else if (resultado >= 5 && resultado < 7)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Aluno em recuperação.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Aluno reprovado.");
}
