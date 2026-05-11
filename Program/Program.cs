using Game;
namespace Program;


class Programm
{
    public static int Main()
    {
       Board brett = new Board();

        // Eine Figur erstellen
        Figure tower_white = new Figure('t', 0, 0);

        brett.Felder[0, 0] = tower_white;
        int count = 0;
        while (count < 50)
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