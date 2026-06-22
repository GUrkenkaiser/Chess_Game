namespace Figuren;
using Game;

public class Figures
{ 
    Figure verkettung;

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
