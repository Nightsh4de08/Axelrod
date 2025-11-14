using System;


class Program

{

static void Main(string[] args)

{

int rodadas = 10;

int pontosJogador = 0;

int pontosBot = 0;

bool botUltimaAcao = true;

Console.WriteLine("Digite 'C' para Cooperar ou 'T' para Trair.");

Console.WriteLine("O jogo terá 10 rodadas.\n");


for (int i = 1; i <= rodadas; i++)

{

Console.WriteLine($"\n--- Rodada {i} ---");

Console.Write("Sua escolha (C/T): ");

string escolha = Console.ReadLine().Trim().ToUpper();


bool jogadorCooperou;


if (escolha == "C")

jogadorCooperou = true;

else if (escolha == "T")

jogadorCooperou = false;

else

{

Console.WriteLine("Escolha inválida considerado como traição (T).");

jogadorCooperou = false;

}


bool botCooperou = botUltimaAcao;


Console.WriteLine(botCooperou ? "Bot cooperou." : "Bot traiu.");


            if (jogadorCooperou && botCooperou)

            {

                pontosJogador += 3;

                pontosBot += 3;

                Console.WriteLine("Ambos cooperaram (+3 cada).");

            }

            else if (!jogadorCooperou && botCooperou)

            {

                pontosJogador += 5;

                pontosBot += 0;

                Console.WriteLine("Você traiu o bot (+5 pra você).");

            }

            else if (jogadorCooperou && !botCooperou)

            {

                pontosJogador += 0;

                pontosBot += 5;

                Console.WriteLine("O bot traiu você (+5 pro bot).");

            }

            else

            {

                pontosJogador += -1;

                pontosBot += -1;

                Console.WriteLine("Ambos traíram (-1 cada).");

            }

pontosJogador = Math.Max(0, pontosJogador);
pontosBot = Math.Max(0, pontosBot);

botUltimaAcao = jogadorCooperou;


Console.WriteLine($"Placar parcial -> Você: {pontosJogador} | Bot: {pontosBot}");

}


Console.WriteLine("\n FIM DO JOGO");

Console.WriteLine($"Placar final \n Você: {pontosJogador} | Bot: {pontosBot}");


if (pontosJogador > pontosBot)

Console.WriteLine(" Você venceu!");

else if (pontosJogador < pontosBot)

Console.WriteLine(" O bot venceu!");

else

Console.WriteLine(" Empate!");

}

}