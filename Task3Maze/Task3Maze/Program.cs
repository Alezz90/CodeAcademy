namespace Task3Maze
{
    internal class Program
    {
        static char[,] MazS(char e=' ') {
            int nx = 2;
            int zy = 5;
            switch (e)
            {
                case 'U':
                    nx-=1;
                    break;
                case 'L':
                    zy-= 1;
                    break;
                case 'D':
                    nx+= 1;
                    break;
                case 'R':
                    zy+= 1;
                    break;

            }
            int x = 8;
            int y = 10;
            char[,] Maz = new char[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //squer border
                    if (i == 0 || i == x - 1 || j == 0 || j == y - 1)
                    {
                        Maz[i, j] = '#';
                    }
                    else if (i == 2 && j == 4 || i == 3 && j == 4 || i == 4 && j == 4 || i == 3 && j == 3)
                    //Squer insid
                    {
                        Maz[i, j] = '#';
                    }
                    else if (i == 8 && j == 9)
                    //Squer E
                    {
                        Maz[i, j] = 'x';
                    }
                    else if (i == nx && j == zy)
                    //Squer E
                    {
                        if (Maz[i, j] != '#')
                        {
                            Maz[i, j] = 'E';
                            nx = i;
                            zy=j;
                        }


                    }
                    else//Squer Empty
                    {
                        Maz[i, j] = ' ';
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(Maz[i, j]);
                  
                }
                Console.WriteLine();
            }

            return Maz;
        }
        static void YX(out int xx, out int yy)
        {
            xx = 1;
            yy = 2;
        }
        static void Main(string[] args)
        {
            int xx = 0;
            int yy = 0;


           MazS();
            while (true)
            {
                Console.WriteLine("Enter to U-Up,D-Down,L-left,R-right");
                char E = Convert.ToChar(Console.ReadLine());
                MazS(E);
            }
        }
    }
}