public class TicTacToe
{
    static void main(String[] args)
    {
        string[,] TTT = { {"1","2","3" },{"4","5","6"},{"7","8","9" } };
        int counter = 0;//for constructor use nothing else
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                TTT[i,j] = Convert.ToString(counter);
                counter++;
            }
        }
        display(TTT);
    }
    public static void display(String[,]arr)
    {
        for(int i = 0;i < 3;i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i,j]);
            }
            if(i!=2) 
                Console.WriteLine("------");
        }
    }
}