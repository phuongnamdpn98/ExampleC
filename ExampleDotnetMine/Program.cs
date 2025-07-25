﻿public class Program
{
    public static void Main(string[] args)
    {
        string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
        int MAP_HEIGHT = map.GetLength(0);
        int MAP_WIDTH = map.GetLength(1);

        string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
        for (int y = 0; y < MAP_HEIGHT; y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                string curentCell = map[y, x];
                if (curentCell.Equals("*"))
                {
                    mapReport[y, x] = "*";
                }
                else
                {
                    int[,] NEIGHBOURS_ORDINATE = {
                        {y - 1, x - 1}, {y - 1, x}, {y - 1, x + 1},
                        {y, x - 1}, {y, x + 1},
                        {y + 1, x - 1}, {y + 1, x}, {y + 1, x + 1},};

                    int minesAround = 0;
                    int length = NEIGHBOURS_ORDINATE.GetLength(0);
                    for (int i = 0; i < length; i++)
                    {
                        int xOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                        int yOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                        bool isOutOfMapNeighbour = xOfNeighbour < 0
                                || xOfNeighbour == MAP_WIDTH
                                || yOfNeighbour < 0
                                || yOfNeighbour == MAP_HEIGHT;
                        if (isOutOfMapNeighbour)
                        {
                            continue;
                        }

                        bool isMineOwnerNeighbour = map[yOfNeighbour, xOfNeighbour].Equals("*");
                        if (isMineOwnerNeighbour)
                        {
                            minesAround++;
                        }
                    }

                    mapReport[y, x] = minesAround.ToString();
                }
            }
        }

        for (int y = 0; y < MAP_HEIGHT; y++)
        {
            Console.WriteLine("\n");
            for (int x = 0; x < MAP_WIDTH; x++)
            {
                String currentCellReport = mapReport[y, x];
                Console.Write(currentCellReport);
            }
        }
        Console.ReadLine();
    }
}