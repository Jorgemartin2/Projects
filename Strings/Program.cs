using System.Linq.Expressions;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterpolationStrings();
            //ComparationStrings();
            Manipulation();
        }
        static void InterpolationStrings()
        {
            //INTERPOLAÇÃO DE STRINGS
            var price = 10.2 + 7.3;
            var text = "o valor do produto é " + price + " apenas na promoção!";
            var text2 = string.Format("o preço do produto é {0} apenas na promoção {1}!", price, true);
            var text3 = $"o preço do produto é {price} apenas na black friday!";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
        }
        static void ComparationStrings()
        {
            //COMPARAÇÃO DE STRINGS

            var text = "testando";

            //RETORNA 0=TRUE E -1=FALSE
            Console.WriteLine(text.CompareTo("testando"));
            Console.WriteLine(text.CompareTo("Testando"));

            var text1 = "este texto tem a palavra csharp";

            //RETORNA TRUE OU FALSE SE A PALAVRA EXISTE OU NÃO NA VARIÁVEL
            Console.WriteLine(text1.Contains("csharp"));
            Console.WriteLine(text1.Contains("bola"));

            //ESSA FUNÇÃO IGNORA LETRAS MAIUSCULAS E MINUSCULAS(CASE SENSITIVE)
            Console.WriteLine(text1.Contains("Csharp", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("");

            //STRATSWITH = COMEÇA COM
            Console.WriteLine(text1.StartsWith("este"));
            Console.WriteLine(text1.StartsWith("Este"));
            Console.WriteLine(text1.StartsWith("ESte", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("");

            //ENDSWITH = TERMINA COM
            Console.WriteLine(text1.EndsWith("csharp"));
            Console.WriteLine(text1.EndsWith("chip"));
            Console.WriteLine(text1.EndsWith("p"));
            Console.WriteLine("");

            //EQUALS = È IGUAL
            Console.WriteLine(text1.Equals("este texto tem a palavra csharp"));
            Console.WriteLine(text1.Equals("Este texto tem a palavra csharp"));
            Console.WriteLine(text1.Equals("Este teXto tem a palavra csharp", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("");

            //INDEXOF = BUSCA A POSIÇÂO DO CARACTERE
            Console.WriteLine(text1.IndexOf("tem"));
            //BUSCA A ULTIMA LETRA QUE FOI PASSADA
            Console.WriteLine(text1.LastIndexOf("s"));
            Console.WriteLine("");

            //UPPER = TUDO MAIUSCULO; LOWER = TUDO MINUSCULO
            Console.WriteLine(text1.ToLower());
            Console.WriteLine(text1.ToUpper());
            Console.WriteLine("");

            //INSERT = INSERE NOVO TEXTO NA POSIÇÂO; REMOVE = REMOVE O CARACTERE NA POSIÇÂO 
            Console.WriteLine(text1.Insert(5, "PROGRAMAÇÂO"));
            Console.WriteLine(text1.Remove(5, 5));

        }
        static void Manipulation()
        {
            var text = " C# é a melhor linguagem de programação ";

            // TROCA UM CARACTERE OU UMA PALAVRA POR OUTRA
            Console.WriteLine(text.Replace("melhor", "pior"));

            var division = text.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);
            Console.WriteLine(division[5]);
            Console.WriteLine(division[6]);

            //IRÁ EXIBIR OS CARACTERES DAS POSIÇÕES QUE PASSAR
            var result = text.Substring(7, 6);
            Console.WriteLine(result);

            var result1 = text.Substring(3, text.LastIndexOf("m"));
            Console.WriteLine(result1);

            //TRIM = REMOVE ESPAÇOS NO COMEÇO E NO FINAL
            Console.WriteLine(text.Trim());
            Console.WriteLine("");

            var text1 = new StringBuilder();
            text1.Append("esse texto é um teste");
            Console.WriteLine(text1);
        }
    }
}