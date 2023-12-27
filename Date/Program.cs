namespace Date;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Exibe a data e hora atual
        var date = DateTime.Now;
        Console.WriteLine(date);
        //Ano
        Console.WriteLine(date.Year);
        //Mês
        Console.WriteLine(date.Month);
        //Dia
        Console.WriteLine(date.Day);
        //Hora
        Console.WriteLine(date.Hour);
        //Minuto
        Console.WriteLine(date.Minute);
        //Segundo
        Console.WriteLine(date.Second);
        //Dia da semana
        Console.WriteLine(date.DayOfWeek);
        //Dia da semana em número (1-segunda, 2-terça...)
        Console.WriteLine((int)date.DayOfWeek);
        //Dia do ano
        Console.WriteLine(date.DayOfYear);

        //y = Ano
        //M = mês
        //d = dia
        //H = hora
        //m = minuto
        //s = segundo

        //r = formato de data e hora padrão que muitos sistemas usam
        var formatted = string.Format("{0:r}", date);
        Console.WriteLine(formatted);
    }
}