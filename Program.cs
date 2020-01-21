using System;
using System.Globalization;

namespace Exercicio_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.WriteLine("Deseja alterar a quantidade? Sim - 1 / Não - 2");
            int adp = int.Parse(Console.ReadLine());

            while (adp == 1)
            {

                Console.WriteLine("Deseja adicionar ou remover? Adicionar - 1 / Remover - 2 / Sair - 0");
                int adicionarRemoverSair = int.Parse(Console.ReadLine());

                if (adicionarRemoverSair == 1)
                {
                    Console.WriteLine();
                    Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);

                    Console.WriteLine();
                    Console.WriteLine("Desenha adiconar mais? Sim - 1 / Não - 2");
                    int adicionar = int.Parse(Console.ReadLine());

                    while (adicionar == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
                        qte = int.Parse(Console.ReadLine());
                        p.AdicionarProdutos(qte);

                        Console.WriteLine();
                        Console.WriteLine("Desenha adiconar mais? Sim - 1 / Não - 2");
                        adicionar = int.Parse(Console.ReadLine());

                        if (adicionar == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
                            qte = int.Parse(Console.ReadLine());
                            p.AdicionarProdutos(qte);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Dados do produto: " + p);
                        }
                        break;
                    }
                }
                else if (adicionarRemoverSair == 2)
                {
                    Console.WriteLine();
                    Console.Write("Digite o número de produto a ser removido ao estoque: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qte);

                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);

                    Console.WriteLine();
                    Console.WriteLine("Desenha remover mais? Sim - 1 / Não - 2");
                    int remover = int.Parse(Console.ReadLine());

                    while (remover == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
                        qte = int.Parse(Console.ReadLine());
                        p.RemoverProdutos(qte);

                        Console.WriteLine();
                        Console.WriteLine("Desenha adiconar mais? Sim - 1 / Não - 2");
                        remover = int.Parse(Console.ReadLine());

                        if (remover == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
                            qte = int.Parse(Console.ReadLine());
                            p.RemoverProdutos(qte);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Dados do produto: " + p);
                        }
                        break;
                    }
                }
                else if ( adicionarRemoverSair == 0 )
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
