namespace Task3Maze
{
    class Program
    {
        static int prevX = 2;
        static int prevY = 5;
        static string[,] Maz()
        {
            int x = 9;
            int y = 11;


            string[,] Maz = new string[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0 || i == x - 1 || j == 0 || j == y - 1 || (i >= 2 && i <= 4 && j == 4) || (i == 3 && j == 3))
                    {
                        Maz[i, j] = "#";
                    }
                    else if (i == prevX && j == prevY)
                    {
                        Maz[i, j] = "E";
                    }
                    else if (i == 7 && j == 8)
                    {
                        Maz[i, j] = "Exit";
                    }

                    else
                    {
                        Maz[i, j] = " ";
                    }
                }
            }
            return Maz;
        }
        static void printMaz()
        {
            string[,] MazPrint = Maz();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(MazPrint[i, j]);
                }
                Console.WriteLine();
            }
        }
        static string MazPlay(string e)
        {
            int newx = prevX;
            int newy = prevY;
            string[,] MazE = Maz();
            switch (e)
            {
                case "U":
                    newx -= 1;
                    break;
                case "L":
                    newy -= 1;
                    break;
                case "D":
                    newx += 1;
                    break;
                case "R":
                    newy += 1;
                    break;
            }
            if (newx == 7 && newy == 8)
            {

                Console.WriteLine("congratulations ");
                return "Finsh";
            }
            else if (newy >= 0 || newy < 9 || newy >= 0 || newy < 10)
            {
                if (MazE[newx, newy] != "#" && MazE[newx, newy] != "Exit")
                {
                    MazE[newx, newy] = "E";
                    MazE[prevX, prevY] = " ";
                    prevX = newx;
                    prevY = newy;
                    printMaz();
                    return "s";

                }
            }
            return "e";
        }

        static void Main(string[] args)
        {
            printMaz();
            while (true)
            {

                Console.WriteLine("Enter U-Up, D-Down, L-Left, R-Right");
                string move = Console.ReadLine().ToUpper();

                if (move == "U" || move == "R" || move == "D" || move == "L")

                {
                    string moveSuccessful = MazPlay(move);

                    if (moveSuccessful == "Finsh")
                    {
                        break;
                    }
                    if (moveSuccessful == "e")
                    {
                        Console.WriteLine(" move error");
                    }
                }


            }
        }
    }
}