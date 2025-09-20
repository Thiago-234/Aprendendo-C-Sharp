string teste = "teste"; // Armazena um texto
int num = 123;  // Armazena um inteiro (até 32 bits)
long num2 = 12345678901234;  // Armazena um inteiro longo (até 64 bits) long > int

// $ -> Serve para colocar váriaveis dentro de uma string, sem precisar concatenar (Interpolação de string)

Console.WriteLine($"Palavra = {teste}, Numero = {num}, Numero Longo = {num2}");

float num3 = 26.11f;  // Suporta até 32 bits
double num4 = 10.10;  // Suporta até 64 bits
decimal decima1 = 100.99m;  // Suporta até 128 bits

Console.WriteLine($"Numero Float = {num3}, Numero Double = {num4}, Numero Decimal = {decima1}");

bool maiorIdade = false;    // Suporta apenas true ou false (lógico)
Console.WriteLine($"Maior de Idade = {maiorIdade}");

char letra = 'A';  // Suporta apenas 1 caractere
Console.WriteLine($"Letra = {letra}");

var variavel = "Teste Variavel";   // É uma variavel dinâmica, não necessário especificar o tipo de dado
Console.WriteLine($"Var dinâmica = {variavel}");

// Convertendo valores
// Implicita e Explícita -> Implicita é automática pelo compilador, Explícita é manual (usando casting)
// Casting -> São as conversões explícitas, exemplo: (int) ou (double)
double numDouble = num; // Variavel do tipo int para double (conversão implícita)
int numInt = (int)num4; // Variavel do tipo double para int (conversão explícita)

// Conversor -> São métodos que convertem um tipo de dado em outro
// Convert.ToInt32(variavel) -> Converte para int
// Convert.ToInt64(variavel) -> Converte para long, (é um int, mas de 64 bits)
// Convert.ToDouble(variavel) -> Converte para double
// Convert.ToDecimal(variavel) -> Converte para decimal
// Convert.ToString(variavel) -> Converte para string
string saldo = "1000";
int saldoInt = Convert.ToInt32(saldo);
Console.WriteLine($"Saldo = {saldoInt}");