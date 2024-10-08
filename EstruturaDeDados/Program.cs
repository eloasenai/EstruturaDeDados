﻿internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA (LIST)
        List<string> frutas = new List<string>();

        /*ADICIONAR ITENS NA LISTA*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /*IMPRIMIR OS ITENS DA LISTA*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        /*IMPRIMIR ELEMENTO NO INDICE ESPECIFICA*/
        Console.WriteLine("Fruta na indice 2:" + frutas[2]);

        /*INSERIR UM ELEMENTO NO INDICE  ESPECIFICA*/
        frutas.Insert(1, "Maracuja");

        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine(); //PULA LINHA EM BRANCO 

        Console.WriteLine("Minha Lista de frutas:");
        frutas.ForEach(Console.WriteLine);

        /*ALTERNAR UM ELEMENTO NO ÍNDICE ESPECIFICO*/
        frutas[4] = "Pêra";
        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        frutas.ForEach(Console.WriteLine);

        /*REMOVER ELEMENTOS DA LISTA NO INDICE ESPECÍFICO*/
        frutas.Remove("Morango");
        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        frutas.ForEach(Console.WriteLine);

        /* APAGAR TODOS OS ELEMENTOS DA LISTA */
        frutas.Clear();

        //TRABALHANDO COM DICIONARIO (DICIONARY)
        /* CRIANDO UM DICIONARIO DE DADOS */
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* ADICIONAR DADOS E UM DICIONARIO*/
        carros.Add(5, "Corsa");
        carros.Add(10, "fusca");
        carros.Add(2, "Ford ka");

        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO

        Console.WriteLine("Meu Dicionario de Carros:");
        /*IMPRIMIR UM DICIONARIO  DE DADOS */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO

        //TRABALHANDO COM FILA //
        /*CRIAR UMA FILA (QUEUE)*/
        Queue<string> filaBanco = new Queue<string>();

        /*ADICIONAR ELEMENTOS EM UMA FILA */
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        /*RETIRAR O */
        filaBanco.Dequeue();

        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        /*VERIFICAR SE EXISTE UM ELEMENTO NA FILA*/

        bool achou = filaBanco.Contains("Manoel");

        if (achou)
        {
            Console.WriteLine("A pessoa esta na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não esta la fila");
        }

        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO

        // TRABALHANDO COM PILHA (STRAK)
        /*CRIANDO UMA PILHA*/
        Stack<string> Livros = new Stack<string>();

        //ADICIONAR ELEMENTOS COM CRIANDO UMA PILHA*/
        Livros.Push("Chapeuzinho Vermelho");
        Livros.Push("Branca de neve e os sete anões");
        Livros.Push("Princesa e o sapo");

        foreach (var livro in Livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO

        /*REMOVE O PRIMEIRO ELEMENTO DA PILHA*/
        Livros.Pop();
        foreach (var livro in Livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();//PULA LINHA EM BRANCO
        Console.WriteLine("===============================");
        Console.WriteLine();//PULA LINHA EM BRANCO
    }
}