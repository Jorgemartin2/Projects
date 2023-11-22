using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text.Json;
using System.Threading.Tasks;

namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }
    public static void Line()
    {
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }
    public static void DrawScreen()
    {
        Line();
        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }
        Line();
    }
    public static void WriteOptions()
    {
        Console.SetCursorPosition(2, 0);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("==========");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(2, 8);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(2, 10);
        Console.WriteLine("Opção:");
        Console.SetCursorPosition(8, 10);
    }
    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("view"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Show(); break;
        }
    }
}
