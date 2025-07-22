using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        int pos;
        String result = "";
        TicTacToe game = new TicTacToe();
        game.displayBoard();
        Console.Write("\nEnter position from 1 to 9 to make a move : ");
        while (game.isWin() != true)
        {
            pos = int.Parse(Console.ReadLine());
            result = game.makeMove(pos);
            game.displayBoard();
            if (result.ToLower().Equals("error in input"))
                Console.WriteLine("\nInvalid Entry");
            if (result.ToLower().Equals("already filled"))
                Console.WriteLine("\nPosition already filled, try again");
            if (result.ToLower().Equals("draw"))
            {
                Console.WriteLine("\nGame Draw");
                break;
            }
            if (result == "X" || result == "O")
            {
                Console.WriteLine("\n" + result + " Won!");
                break;
            }
            Console.Write("\nEnter Mone from 1 to 9 : ");
        }
    }

}
public class TicTacToe 
{ 
    private String[,] board = new String[3, 3];
    private int NumberOfTry = 0;
    public TicTacToe()
    {
        int count = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = Convert.ToString(count);
                count++;
            }
        }
    }

    public String makeMove(int position)
    {
        if (position < 1 || position > 9)
            return "Error In Input";//invlaid position
        String playerSymbol = NumberOfTry % 2 == 0 ? "X" : "O";
        int row = (position - 1) / 3;
        int col = (position - 1) % 3;
        if (board[row, col] != "X" && board[row, col] != "O")
        {
            board[row, col] = playerSymbol;
            NumberOfTry++;

            if (isWin())
                return playerSymbol; //win

            if (NumberOfTry == 9)
                return "Draw"; //draw

            return "go";

        }
        return "Already Filled";//continue
    }
    public void displayBoard() {
        Console.WriteLine("\n---Board---\n");
        for(int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(board[i, j] + " ");
            }
            if (i < 2)
                Console.WriteLine("\n-----");
        }
    }

    public Boolean isWin()
    {
        if (board[0, 0].Equals(board[1, 1]) && board[0, 0].Equals(board[2, 2]))
            return true;
        if (board[0, 2].Equals(board[1, 1]) && board[0, 2].Equals(board[2, 0]))
            return true;
        if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
            return true;
        if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
            return true;
        if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
            return true;
        if (board[0,0] == board[1, 0] && board[0, 0] == board[2, 0])
            return true;
        if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
            return true;
        if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
            return true;
        return false;
    }
}