namespace validSudoku;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var retVal = IsValidSudoku(new char[][]{});
    }

    public static bool IsValidSudoku(char[][] board) 
    {
        HashSet<string> vals = new HashSet<string>();
        for(var i = 0 ; i< 9; i ++)
        {
            for(var j = 0 ; j < 9; j++)
            {
                if(board[i][j] == '.')
                continue;
                if (!vals.Add("(" + board[i][j] + ")" + i + " in row") || 
                    !vals.Add("(" + board[i][j] + ")" + j + " in column") || 
                    !vals.Add("(" + board[i][j] + ")" + i / 3 + "-" + j / 3 + " in block")) {
                    return false;
                    }
            }
        }
        return true;
    }
}
