PlayerTracker tracker = new PlayerTracker(0,0);

string[,] Board = new string[5,5];

string TestPlayer = "Player1";

tracker.MovePlayer(tracker, Board, TestPlayer);
tracker.MovePlayer(tracker, Board, TestPlayer);
tracker.MovePlayer(tracker, Board, TestPlayer);
tracker.MovePlayer(tracker, Board, TestPlayer);
Console.ReadKey();
//********************************************************************************************
public class PlayerTracker
{
    int Row;
    int Col;

    public PlayerTracker(int row, int col)
    {
        Row = row;
        Col = col;
    }

    public void MovePlayer(PlayerTracker tracker, string[,] board, string TestPlayer)
    {


        board[Row, Col] = null;
        Row++;
        Col = Col;
        board[Row, Col] = TestPlayer;
        Console.WriteLine($"{tracker.Row},{tracker.Col}");


    }
}
 






