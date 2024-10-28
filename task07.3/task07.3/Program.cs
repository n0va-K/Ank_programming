using System;

class Program
{
    static void Main(string[] args)
    {
        string whiteKingPosition, blackRookPosition, movePosition;

        Console.WriteLine("Введите позицию белого короля:");
        whiteKingPosition = Console.ReadLine();

        Console.WriteLine("Введите позицию черной ладьи:");
        blackRookPosition = Console.ReadLine();

        if (!IsValidPosition(whiteKingPosition) || !IsValidPosition(blackRookPosition) || whiteKingPosition == blackRookPosition)
        {
            Console.WriteLine("Некорректные позиции фигур.");
            Console.ReadKey();
            return;
        }

        DecodePosition(whiteKingPosition, out int whiteColumn, out int whiteRow);
        DecodePosition(blackRookPosition, out int blackColumn, out int blackRow);


        if (IsUnderAttack(blackColumn, blackRow, whiteColumn, whiteRow))
        {
            Console.WriteLine("Белый король под боем черной ладьи.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите позицию хода белого короля:");
        movePosition = Console.ReadLine();

        if (!IsValidPosition(movePosition))
        {
            Console.WriteLine("Некорректная позиция хода.");
            Console.ReadKey();
            return;
        }

        DecodePosition(movePosition, out int moveColumn, out int moveRow);

        if (MoveCorrect(whiteColumn, whiteRow, moveColumn, moveRow) && !IsUnderAttack(blackColumn, blackRow, moveColumn, moveRow))
        {
            Console.WriteLine("Ход возможен.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Ход невозможен или под боем.");
            Console.ReadKey();
        }

    }

    static bool IsValidPosition(string position)
    {
        if (position.Length != 2) return false;

        char column = position[0];
        char row = position[1];

        return column >= 'a' && column <= 'h' && row >= '1' && row <= '8';
    }

    static void DecodePosition(string position, out int col, out int row)
    {
        col = position[0] - 'a';
        row = position[1] - '1';
    }

    static bool MoveCorrect(int startColumn, int startRow, int targetColumn, int targetRow)
    {
        return Math.Abs(startColumn - targetColumn) <= 1 && Math.Abs(startRow - targetRow) <= 1;
    }

    static bool IsUnderAttack(int attackerColumn, int attackerRow, int targetColumn, int targetRow)
    {
        return attackerColumn == targetColumn || attackerRow == targetRow;
    }
}
