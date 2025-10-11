const double CarnePorAdulto = 0.4, CarnePorCrianca = 0.2;
const double AcompanhamentosPorPessoa = 0.2;
const double CervejaPorAdulto = 2;
const double RefrigerantePorPessoa = 0.5;
const double AguaPorPessoa = 0.4;

int adultosSemAlcool, adultosComAlcool, criancas, adultos, pessoas;
double carne, acompanhamentos, cerveja, refrigerante, agua;

Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas álcoolicas).......: ");
adultosComAlcool = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Adultos (que não consomem bebidas álcoolicas)...: ");
adultosSemAlcool = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Crianças........................................: ");
criancas = Convert.ToInt32(Console.ReadLine()!);

adultos = adultosComAlcool + adultosSemAlcool;
pessoas = adultos + criancas;

carne = adultos * CarnePorAdulto + criancas * CarnePorCrianca;
acompanhamentos = pessoas * AcompanhamentosPorPessoa;
cerveja = adultosComAlcool * CervejaPorAdulto;
refrigerante = (adultosSemAlcool + criancas) * RefrigerantePorPessoa;
agua = pessoas * AguaPorPessoa;

Console.WriteLine($"\nCarne...........:{carne:N1}kg");
Console.WriteLine($"Acompanhamentos...:{acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"Refrigerante......:{refrigerante:N1}l");
Console.WriteLine($"Água..............:{agua:N1}l");
