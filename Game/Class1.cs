namespace Game;

public class Board
{
    private string board_border =   "+---+---+---+---+---+---+---+---+\n";
    private string board_black = "| # ";
    private string board_white = "|   ";
    private string King_black = "| K ";
    private string Queen_black = "| Q ";
    private string board_End = "|\n";
    



    public Board()
    {

    }
    public override string ToString() 
    {
        string board ="";
        int count1 = 0;
        int count2 = 0;
        bool Change = true;
        while(count1 < 30)
        {
            if(count2 < 0)
            {
                board += board_End;
                board += board_border;
                count2 = 8;
                Change = !Change;
                

            }
            if(Change == true)
            {
                board += board_white;
                Change = false;
                count2 --;
            }
            if (Change == false)
            {
                board += board_black;
                Change = true;
                count2 --;

            }
            count1 ++;
        }
        return board;

    }
}
