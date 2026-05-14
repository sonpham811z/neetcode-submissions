public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<string, int> box = new Dictionary<string, int>(); 
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if(board[i][j] != '.')
                {
                    string index_row = $"row{i}_{board[i][j]}";
                    string index_box = $"box{(i/3)*3 + (j/3)}_{board[i][j]}";
                    if(!box.TryAdd(index_row,1) || !box.TryAdd(index_box,1))
                        return false;
                }
                if(board[j][i] != '.')
                {
                    string index_column = $"column{i}_{board[j][i]}";
                     if(!box.TryAdd(index_column,1))
                        return false;
                }
                
            }
        }

        return true;
    }
}
