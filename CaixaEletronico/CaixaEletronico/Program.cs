using System;

namespace Caixa.Eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;

            Console.WriteLine("Sistema de Caixa Eletrônico\n");

            while (escolha != 2)
            {
                Console.WriteLine("1 - SAQUE");
                Console.WriteLine("2 - SAIR...");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        Console.WriteLine("Informe o valor que deseja sacar:");
                        int valor = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (valor <= 1)
                        {
                            Console.WriteLine("Valor para saque incompatível com as notas");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (valor % 2 != 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Quantidade de notas:");
                                Console.WriteLine();

                                valor = valor - 5;

                                int n100 = valor / 100;
                                int resto = valor - (n100 * 100);

                                if (n100 != 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Notas de R$ 100: " + n100);
                                }

                                int n50 = resto / 50;
                                resto -= (n50 * 50);

                                if (n50 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 50: " + n50);
                                }

                                int n20 = resto / 20;
                                resto -= (n20 * 20);

                                if (n20 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 20: " + n20);
                                }

                                int n10 = resto / 10;
                                resto -= (n10 * 10);

                                if (n10 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 10: " + n10);
                                }

                                Console.WriteLine("Notas de R$ 5: 1");


                                int n2 = resto / 2;
                                resto = (n2 * 2);

                                if (n2 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 2: " + n2);
                                }

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Quantidade de notas:");
                                Console.WriteLine();

                                int n100 = valor / 100;
                                int resto = valor - (n100 * 100);

                                if (n100 != 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Notas de R$ 100: " + n100);
                                }

                                int n50 = resto / 50;
                                resto -= (n50 * 50);

                                if (n50 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 50: " + n50);
                                }

                                int n20 = resto / 20;
                                resto -= (n20 * 20);

                                if (n20 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 20: " + n20);
                                }

                                int n10 = resto / 10;
                                resto -= (n10 * 10);

                                if (n10 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 10: " + n10);
                                }


                                //int n5 = resto / 5;

                                //if (n5 % 2 == 0)
                                //{
                                //    resto -= (n5 * 5);

                                //    if (n5 != 0)
                                //    {
                                //        Console.WriteLine("Notas de R$ 5: " + n5);
                                //    }
                                //}

                                int n2 = resto / 2;
                                resto = (n2 * 2);

                                if (n2 != 0)
                                {
                                    Console.WriteLine("Notas de R$ 2: " + n2);
                                }

                                Console.WriteLine();
                            }

                        }
                        break;

                    case 2:
                        Console.WriteLine("Saindo do Sistema...");
                        break;
                }
            }
        }
    }
}