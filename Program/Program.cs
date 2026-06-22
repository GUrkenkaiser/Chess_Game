using Game;
namespace Program;


class Programm
{
    public static int Main()
    {
       Board brett = new Board();

        // Eine Figur erstellen
        Figure turmWhite1 = new Figure('t', 0, 0);
        Figure turmWhite2 = new Figure('t', 7, 0);
        Figure koenigWhite = new Figure('k',4,0);

        brett.Felder[0, 0] = turmWhite1;
        brett.Felder[7, 0] = turmWhite2;
        brett.Felder[4, 0] = koenigWhite;
        int count = 0;
        while (count < 5)
        {

            Console.WriteLine(brett);

            Console.WriteLine("Figur bewegen");
            Console.Write("Von X: ");
            int vonX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Von Y: ");
            int vonY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nach X: ");
            int nachX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nach Y: ");
            int nachY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Art der Figur: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            brett.Move(vonX, vonY, nachX, nachY, symbol);
            count ++;
        }
    return 0;
    }
    
}