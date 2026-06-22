using System.Security.Cryptography.X509Certificates;

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
    /*
    public bool Move_OK(int toX, int toY, char symbol) {

        
        if (symbol == 't' || symbol == 'T')
        {
            if (X== toX || Y == toY)
            {
                return true;
            }
            else
            {
               return false; 
            }
            
        } 
        
        return false;
    }
*/
    
}

public class Board
{
public Figure[,] Felder = new Figure[8, 8];

public bool Move_OK(int vonX, int vonY, int toX, int toY, char symbol) {

        // Überprüfung ob der Turm sich so bewegen darf
        if (symbol == 't' || symbol == 'T')
        {
            //entweder Gleiche X oder Y Achse
            if (vonX == toX || vonY == toY)
            {
                return true;
            }
            if (vonY < toY)
            {
                int countY = vonY+1;
                Figure figur = Felder[vonX, countY];
                while (countY < toY )
                {
                    figur = Felder[vonX, countY];
                    if (figur != null)
                    {
                        Console.WriteLine("Da ist etwas im Weg!\n");
                        return false;
                    }
                    countY ++;
                    
                }  
            }
            if (vonY > toY)
            {
                int countY = toY+1;
                Figure figur = Felder[vonX, countY];
                while (countY < vonY )
                {
                    figur = Felder[vonX, countY];
                    if (figur != null)
                    {
                        Console.WriteLine("Da ist etwas im Weg!\n");
                        return false;
                    }
                    countY ++;
                    
                }  
            }
            if (vonX < toX)
            {
                int countX = vonX+1;
                Figure figur = Felder[countX, vonY];
                while (countX < toX )
                {
                    figur = Felder[vonX, countX];
                    if (figur != null)
                    {
                        Console.WriteLine("Da ist etwas im Weg!\n");
                        return false;
                    }
                    countX ++;
                    
                }  
            }
            if (vonX > toX)
            {
                int countX = toX+1;
                Figure figur = Felder[countX, vonY];
                while (countX < vonX )
                {
                    figur = Felder[countX, vonY];
                    if (figur != null)
                    {
                        Console.WriteLine("Da ist etwas im Weg!\n");
                        return false;
                    }
                    countX ++;
                    
                }  
            }
            else
            {
               return false; 
            }

        }
        Figure figurCheckKing = Felder[toX, toY];
        if(figurCheckKing.Symbol == 'k' || figurCheckKing.Symbol == 'K')
        {
            return false;
        }
        
        return false;
    }

    public void Move(int vonX, int vonY, int nachX, int nachY, char Symbol)
{
    Figure figur = Felder[vonX, vonY];

    if (figur == null)
    {
        Console.WriteLine("Keine Figur dort!\n");
        return;
    }

    if (Move_OK(vonX,vonY,nachX, nachY, Symbol) == true)
    {
        Felder[nachX, nachY] = figur;
        Felder[vonX, vonY] = null;
        figur.X = nachX;
        figur.Y = nachY;  
        
    }
    else
    {
        Console.WriteLine("Ungültiger Zug bitte noch einmal!\n");
        return;
    }


    
    
  
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

