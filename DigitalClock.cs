using System;
using System.Linq;
class DigitalClock
{
    // Bestimmt in welcher Form die Uhrzeit ausgegeben werden muss
    void DeterminePrint(string input, bool horizontal, bool vertical)
    {
        while (input.Length < 4)
        {
            input = "0" + input;
        }
        // Normale Zeitausgabe
        if(!horizontal && !vertical)
        {
            for (int zeile = 0; zeile <= 4; zeile++)
            {
                foreach (char digit in input)
                {
                    NormalPrintDigit(digit, zeile);
                }
                Console.Write("\n");
            }
        }    
        // Ausgabe mit Spiegelung an der X Achse
        else if (horizontal && !vertical)
        {
            for (int zeile = 4; zeile >= 0; zeile--)
            {
                foreach (char digit in input)
                {
                    NormalPrintDigit(digit, zeile);
                }
                Console.Write("\n");
            }
        }
        // Ausgabe mit Spiegelung an der Y Achse
        else if(!horizontal && vertical)
        {
            for (int zeile = 0; zeile <= 4; zeile++)
            {
                foreach (char digit in input.ToCharArray().Reverse())
                {
                    verticalPrintDigit(digit,zeile);
                }
                Console.Write("\n");
            }
        }   
        // Ausgabe mit Spiegelung an der X und Y Achse
        else if(horizontal && vertical)
        {
            for (int zeile = 4; zeile >= 0; zeile--)
            {
                foreach (char digit in input.ToCharArray().Reverse())
                {
                    verticalPrintDigit(digit,zeile);
                }
                Console.Write("\n");
            }
        }             
    }        
    // Standard Print
    void NormalPrintDigit(char digit, int zeile)
    {
        switch (digit)
        {
            case '0':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '1':
                if(zeile == 0)Console.Write("   ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write("   ");
                break;
            case '2':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '3':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '4':
                if(zeile == 0)Console.Write("   ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write("   ");
                break;
            case '5':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '6':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '7':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write("   ");
                break;
            case '8':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '9':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write(" - ");
                break;
        }
    }
    // Print wenn vertikal gespiegelt wurde
    void verticalPrintDigit(char digit, int zeile)
    {
        switch (digit)
        {
            case '0':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '1':
                if(zeile == 0)Console.Write("   ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write("   ");
                break;
            case '2':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("  |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '3':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '4':
                if(zeile == 0)Console.Write("   ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write("   ");
                break;
            case '5':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '6':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("  |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '7':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("|  ");
                if(zeile == 2)Console.Write("   ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write("   ");
                break;
            case '8':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("| |");
                if(zeile == 4)Console.Write(" - ");
                break;
            case '9':
                if(zeile == 0)Console.Write(" - ");
                if(zeile == 1)Console.Write("| |");
                if(zeile == 2)Console.Write(" - ");
                if(zeile == 3)Console.Write("|  ");
                if(zeile == 4)Console.Write(" - ");
                break;
        }
    }
    public static void Main(string[] args)
    {
        DigitalClock clock = new DigitalClock();
        Console.WriteLine("Hinweis: Mit 'x' kannst du die Zahl an der X-Achse und mit 'y' and der Y-Achse spiegeln ");
        Console.WriteLine("Mit 'b' kannst du das Programm beenden");
        Console.WriteLine("Gib eine 4-stellige Zahl ein");
        bool horizontal = false; //Toggle Bool wenn an horizontal gespiegelt werden soll
        bool vertical = false; //Toggle Bool wenn an vertical gespiegelt werden soll
        string lastinput = "";
        while (true)
        {
            Console.Write("Dein Input: ");
            string input = Console.ReadLine();   
            //Abbruch des Programms
            if(input.Length > 4)
            {
                Console.WriteLine("Bitte eine 4-stellige Zahl eingeben!");
                continue;
            }
            if(input == "b")
            {
                break;
            }           
            // Input von y -> vertical Toggle setzen
            if (input == "y")  
            {
                if(vertical)
                {
                    vertical = false;
                }
                else
                {
                    vertical = true;
                }
                input = lastinput;
                input = new string(input.Reverse().ToArray());
                clock.DeterminePrint(input,horizontal,vertical);
            }
            // Input von x -> horizontal Toggle setzen
            else if (input == "x")
            {
                if(horizontal)
                {
                    horizontal = false;
                }
                else
                {
                    horizontal = true;
                }
                input = lastinput;
                clock.DeterminePrint(input,horizontal,vertical);
            }
            else
            {
                clock.DeterminePrint(input,horizontal,vertical);
            }
            lastinput = input;
        } 
 
    }
}

