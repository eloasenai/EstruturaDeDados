internal class Program
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
        foreach (string fruta in frutas) ;
        {
            Console.WriteLine(fruta);
        }
        /*IMPRIMIR ELEMENTO NO INDICE ESPECIFICA*/
        Console.WriteLine("Fruta na indice 2:" + frutas[2]);

        /*INSERIR UM ELEMENTO NO INDICE  ESPECIFICA*/
        frutas.Insert(1, "Maracuja");

        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine(); //PULA LINHA EM BRANCO 

        Console.WriteLine("Minha Lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        /*ALTERNAR UM ELEMENTO NO ÍNDICE ESPECIFICO*/
        frutas[4] = "Pêra";
        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        foreach (string fruta in frutas) ;
        {
            Console.WriteLine(fruta);
        }
        /*REMOVER ELEMENTOS DA LISTA NO INDICE ESPECÍFICO*/
        frutas.Remove("Morango");
        /*IMPRIMINDO A LISTA NOVAMENTE */
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        frutas.ForEach(Console.WriteLine);
   
        /* APAGAR TODOS OS ELEMENTOS DA LISTA */
        frutas.Clear();
    }
}