namespace Game;

public class Figure
{
    public char Symbol;
    public int X;
    public int Y;

    public Figure(char symbol, int x, int y)
    {
        Symbol = symbol;
        X = x;
        Y = y;
    }
    public bool Move_OK(int toX, int toY, char symbol) {

        if (symbol == 't' || symbol == 'T')
        {
            
        } 
        if (X == toX || Y == toY)
        {
            return true;
        }
        return false;
    }
}

public class Board
{
public Figure[,] Felder = new Figure[8, 8];

    public void Move(int vonX, int vonY, int nachX, int nachY, char Symbol)
{
    Figure figur = Felder[vonX, vonY];

    if (figur == null)
    {
        Console.WriteLine("Keine Figur dort!");
        return;
    }

    if (!figur.Move_OK(nachX, nachY, Symbol))
    {
        Console.WriteLine("Ungültiger Zug bitte noch einmal");
         return;

    }
    Felder[nachX, nachY] = figur;
    Felder[vonX, vonY] = null;

    figur.X = nachX;
    figur.Y = nachY;  

    
}

    public override string ToString()
    {
        string text = "";

        text += "| A | B | C | D | E | F | G | H |\n";
        text += "+---+---+---+---+---+---+---+---+---+\n";

        for (int y = 0; y < 8; y++)
        {
            text += "|";

            for (int x = 0; x < 8; x++)
            {
                Figure figur = Felder[x, y];

                if (figur != null)
                {
                    text += " " + figur.Symbol + " |";
                }
                else
                {
                    if ((x + y) % 2 == 0)
                        text += " # |";
                    else
                        text += "   |";
                }
            }

            text += " " + (y + 1);
            text += "\n";

            text += "+---+---+---+---+---+---+---+---+---+\n";
        }
        return text;
    }
}

