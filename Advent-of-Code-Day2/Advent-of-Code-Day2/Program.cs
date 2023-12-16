namespace Advent_of_Code_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Possible games with 12 red, 13 green, 14 blue
            int sumOfPossibleGames = 0;
            int gameNumber = 1;
            int[] possibleGamesList = { };

            string unformattedGameData = "Game 1: 6 green, 3 blue; 3 red, 1 green; 4 green, 3 red, 5 blue\r\nGame 2: 2 red, 7 green; 13 green, 2 blue, 4 red; 4 green, 5 red, 1 blue; 1 blue, 9 red, 1 green\r\nGame 3: 2 green, 3 blue, 9 red; 3 red, 2 green; 6 red, 4 blue; 6 red\r\nGame 4: 9 red, 3 green; 3 green, 8 red, 6 blue; 12 blue, 4 green, 6 red; 4 green, 18 blue, 11 red; 9 blue, 2 green, 3 red; 14 blue, 7 red\r\nGame 5: 1 blue, 2 green, 3 red; 16 red, 6 green; 6 green, 2 red; 9 red, 1 green\r\nGame 6: 4 green, 7 red, 1 blue; 18 green, 6 blue, 7 red; 1 blue, 3 red, 9 green; 9 red, 19 green, 1 blue; 7 red, 9 green, 4 blue; 5 red, 5 blue, 10 green\r\nGame 7: 16 blue, 5 green, 6 red; 1 blue, 6 red, 9 green; 6 green, 3 red, 2 blue; 2 red, 12 blue, 2 green\r\nGame 8: 6 green, 10 red; 7 red, 6 green, 17 blue; 13 blue, 1 red\r\nGame 9: 2 red, 4 green, 5 blue; 2 green, 5 blue; 4 green, 1 blue; 3 green, 3 red, 6 blue; 3 green\r\nGame 10: 3 green, 5 red, 6 blue; 4 blue, 4 red, 5 green; 5 green, 9 red, 5 blue; 4 green, 6 blue, 10 red\r\nGame 11: 1 blue, 7 red, 9 green; 1 blue, 13 red, 7 green; 5 red; 4 red, 7 green, 2 blue; 7 green, 12 red; 13 red, 2 blue, 12 green\r\nGame 12: 4 blue, 2 red; 9 blue, 2 green, 3 red; 8 blue, 1 green, 1 red; 2 red, 3 green, 11 blue\r\nGame 13: 6 red, 8 green, 2 blue; 6 red, 7 green; 3 green, 3 red; 2 blue; 3 red, 5 green\r\nGame 14: 2 green, 11 blue, 1 red; 5 blue, 1 red, 1 green; 3 green, 12 blue, 2 red\r\nGame 15: 4 blue, 6 red, 7 green; 1 red, 2 blue, 5 green; 6 red, 3 green, 8 blue; 7 green, 8 blue, 4 red\r\nGame 16: 2 red, 16 blue; 2 green, 7 red; 15 blue, 7 red; 2 red, 3 green, 3 blue; 3 red, 1 green, 4 blue; 4 blue, 3 green\r\nGame 17: 2 red, 3 green, 10 blue; 9 red, 4 blue, 3 green; 3 green, 11 red, 6 blue\r\nGame 18: 1 red; 6 green, 1 red, 9 blue; 4 blue, 2 green; 6 blue, 10 green\r\nGame 19: 2 red, 9 green; 2 red, 1 blue; 5 blue, 12 green; 5 green; 8 green, 2 red, 3 blue; 1 red, 11 green\r\nGame 20: 3 green, 2 red, 7 blue; 1 blue, 10 green; 1 red, 14 blue, 13 green; 3 green, 19 blue, 4 red\r\nGame 21: 8 red, 10 blue, 8 green; 2 red, 7 green, 18 blue; 4 green, 11 blue, 4 red; 5 green, 3 blue, 10 red\r\nGame 22: 17 blue, 2 green, 2 red; 8 red, 7 blue; 1 red, 9 blue, 1 green\r\nGame 23: 4 blue, 18 red, 4 green; 3 blue, 7 red; 11 red; 3 blue, 6 red; 19 red\r\nGame 24: 10 red, 1 blue, 17 green; 17 green, 6 red; 14 green, 4 blue\r\nGame 25: 4 blue, 9 green, 4 red; 3 green, 5 blue; 5 blue, 8 green; 3 green, 3 blue, 1 red; 10 green, 1 blue, 4 red; 2 green, 2 blue, 1 red\r\nGame 26: 18 green, 3 red, 12 blue; 2 red, 7 green; 11 blue, 17 green; 12 green, 11 blue; 12 green, 4 blue, 3 red\r\nGame 27: 1 red, 3 blue, 8 green; 15 blue, 8 red, 4 green; 6 red, 9 blue; 6 red, 12 blue, 9 green; 4 red, 7 blue, 15 green\r\nGame 28: 1 red, 14 green; 1 blue, 11 green; 2 green; 4 red, 6 green, 1 blue\r\nGame 29: 1 green, 13 red; 4 red, 16 green, 7 blue; 2 red, 4 blue; 12 green, 8 blue, 4 red; 2 red; 12 red, 5 green\r\nGame 30: 3 green, 4 blue, 3 red; 5 blue, 4 green, 7 red; 5 blue, 2 green, 2 red; 3 red, 1 blue\r\nGame 31: 1 blue, 8 green; 9 green, 2 blue, 1 red; 1 red, 2 blue\r\nGame 32: 11 red, 5 green, 4 blue; 3 blue, 11 red, 8 green; 6 blue, 3 green, 17 red; 4 red, 7 green, 10 blue\r\nGame 33: 6 blue, 4 red; 1 green; 1 green, 4 red, 4 blue; 1 green, 3 red, 10 blue; 10 blue, 1 red\r\nGame 34: 2 green, 3 blue, 3 red; 4 red; 2 red, 2 blue\r\nGame 35: 9 green, 13 blue; 13 blue, 14 red, 1 green; 11 blue, 4 red, 7 green; 5 blue, 5 red, 8 green; 4 red, 2 blue, 2 green\r\nGame 36: 9 red, 5 blue, 8 green; 7 red, 20 blue; 6 green, 16 blue, 5 red; 12 red, 3 blue, 3 green; 3 green, 6 blue, 11 red; 11 red, 8 blue, 3 green\r\nGame 37: 10 green, 11 red, 3 blue; 2 blue, 6 green, 11 red; 9 green, 8 red, 2 blue\r\nGame 38: 2 red, 2 green, 4 blue; 3 red, 4 green, 3 blue; 8 green, 1 blue, 1 red; 3 red, 5 blue, 5 green\r\nGame 39: 3 green, 17 red, 4 blue; 2 green, 20 red; 4 blue, 4 red, 5 green; 5 blue, 7 green, 7 red; 4 blue, 5 green, 16 red\r\nGame 40: 2 green, 2 blue, 4 red; 3 blue, 16 green; 1 green, 2 blue; 1 red; 3 blue, 15 green; 13 green, 1 red, 2 blue\r\nGame 41: 12 red, 10 blue, 9 green; 1 green, 15 red, 4 blue; 2 green, 8 blue, 12 red; 3 red, 4 green, 2 blue; 8 blue, 14 red, 10 green; 9 blue, 7 green, 6 red\r\nGame 42: 5 red, 3 green, 6 blue; 4 blue, 6 green, 2 red; 10 blue; 3 red, 6 green, 10 blue\r\nGame 43: 9 blue, 7 green, 1 red; 2 green, 2 red, 8 blue; 3 red, 15 blue, 11 green; 1 red, 6 blue, 1 green; 2 red, 1 blue; 1 red, 3 green, 7 blue\r\nGame 44: 4 green, 6 red; 15 green, 6 red; 9 green, 16 red, 7 blue; 11 green, 4 blue, 12 red\r\nGame 45: 3 blue, 6 green, 1 red; 4 green, 3 blue; 8 green, 3 blue\r\nGame 46: 10 red, 8 blue; 12 red, 2 green, 17 blue; 17 blue, 6 red, 1 green; 18 red, 6 green, 3 blue; 16 blue, 2 green, 3 red\r\nGame 47: 8 green, 13 red; 8 green, 8 red, 4 blue; 10 red, 3 green; 14 red, 5 green, 8 blue; 7 green, 19 red, 3 blue; 2 red, 5 green, 5 blue\r\nGame 48: 7 green, 9 blue, 3 red; 7 blue, 1 green, 9 red; 7 green, 4 red, 1 blue; 6 green, 3 red, 1 blue\r\nGame 49: 2 red, 3 green; 3 blue, 2 red; 4 red, 3 blue\r\nGame 50: 3 red, 7 blue, 4 green; 2 green, 1 blue, 7 red; 4 red, 1 green, 5 blue\r\nGame 51: 11 red, 6 green, 1 blue; 7 red, 1 blue, 9 green; 15 red, 18 green; 11 green, 1 blue, 11 red; 10 green, 14 red; 1 red, 11 green, 1 blue\r\nGame 52: 18 blue, 1 red, 2 green; 18 blue, 3 green, 1 red; 2 green, 13 blue, 1 red\r\nGame 53: 2 blue, 9 red, 6 green; 1 blue, 3 red; 7 red, 6 blue, 8 green; 2 red, 3 blue, 4 green; 1 green, 2 blue, 2 red\r\nGame 54: 16 red, 4 blue; 1 green, 3 blue, 3 red; 2 green, 12 red; 2 green, 1 blue, 3 red; 10 blue, 6 red, 2 green\r\nGame 55: 1 blue, 4 red, 1 green; 2 blue, 2 red; 13 red, 4 blue, 1 green; 4 blue, 9 red; 1 green, 1 blue, 16 red\r\nGame 56: 12 blue, 12 green; 4 blue, 1 red, 3 green; 2 red, 12 green; 1 red, 11 green, 13 blue; 16 blue, 5 green\r\nGame 57: 1 blue, 3 red; 10 green, 5 red; 5 green, 2 red; 1 red, 13 green\r\nGame 58: 6 blue, 1 red, 6 green; 3 red, 9 blue; 4 red, 9 blue, 5 green; 1 green, 5 red, 7 blue\r\nGame 59: 10 red, 3 green, 3 blue; 6 blue, 11 red, 1 green; 5 green, 10 red; 16 red, 2 blue, 4 green; 3 green, 10 red\r\nGame 60: 2 green, 1 blue; 1 green, 1 blue, 4 red; 3 blue, 1 red, 1 green; 2 red, 2 green; 4 red\r\nGame 61: 5 red, 1 green, 10 blue; 9 red, 10 blue; 1 red, 2 green, 4 blue; 10 blue, 2 green, 9 red; 1 red, 12 blue, 2 green\r\nGame 62: 1 blue, 5 green; 4 blue, 12 green, 1 red; 7 blue, 3 green; 7 blue, 3 green; 3 blue, 1 green, 2 red; 7 blue, 1 red, 12 green\r\nGame 63: 4 blue, 2 green, 5 red; 1 green, 2 red, 2 blue; 4 blue, 2 red, 2 green; 1 blue, 6 red, 2 green; 6 blue, 1 red; 1 green, 9 red, 6 blue\r\nGame 64: 1 green; 3 green, 5 blue, 5 red; 3 red, 3 blue, 3 green; 1 green, 4 red, 6 blue; 5 red\r\nGame 65: 2 red; 1 blue, 1 red; 7 red, 2 blue; 1 green, 4 blue, 3 red\r\nGame 66: 3 red, 9 blue; 1 red, 6 blue, 15 green; 3 green, 3 red, 11 blue\r\nGame 67: 2 red, 1 green, 2 blue; 6 red, 1 green; 1 blue, 1 red, 4 green\r\nGame 68: 3 red, 1 blue; 1 green, 3 red, 2 blue; 1 green, 8 red; 2 blue, 3 red\r\nGame 69: 5 blue, 6 red; 1 green, 15 blue, 10 red; 1 green, 2 red, 4 blue; 5 blue, 7 red; 3 red, 1 green, 11 blue\r\nGame 70: 4 green, 2 red, 8 blue; 5 red, 3 blue; 10 green, 5 blue\r\nGame 71: 1 red, 2 blue, 9 green; 3 red, 8 green; 1 red, 2 blue, 6 green; 3 red, 6 blue, 8 green; 6 green, 3 blue, 2 red; 3 red, 8 green, 6 blue\r\nGame 72: 1 red, 11 green; 1 blue, 7 green, 1 red; 2 red, 12 green; 10 green, 6 red\r\nGame 73: 9 green, 2 red; 1 blue, 3 green; 1 blue, 1 red, 7 green; 2 blue, 9 green, 4 red; 2 blue, 3 red, 8 green; 2 green, 9 red\r\nGame 74: 2 green, 7 red; 1 green, 3 blue, 6 red; 4 green, 3 blue, 6 red; 2 green, 3 blue, 1 red; 3 red, 2 blue, 1 green\r\nGame 75: 15 green, 2 blue; 15 green, 6 red, 2 blue; 12 green, 2 blue, 1 red\r\nGame 76: 1 red, 9 green, 12 blue; 6 red, 12 green, 1 blue; 7 green, 2 blue, 1 red\r\nGame 77: 11 blue, 1 red; 7 blue, 2 red, 13 green; 10 blue, 10 green; 12 blue, 3 red\r\nGame 78: 4 green; 1 blue, 5 green; 5 green, 1 blue, 1 red\r\nGame 79: 4 green, 7 blue, 16 red; 1 blue, 10 red, 5 green; 3 green, 4 red, 3 blue; 11 blue, 18 red, 5 green\r\nGame 80: 1 red, 4 blue, 6 green; 14 blue, 16 red, 2 green; 2 blue, 5 red, 4 green; 2 green, 8 red; 18 red, 6 green, 2 blue; 18 red, 9 blue\r\nGame 81: 11 red, 8 blue, 1 green; 12 blue, 2 green, 14 red; 16 red, 2 green, 6 blue; 17 red, 2 green; 3 green, 3 blue, 15 red\r\nGame 82: 13 red, 1 blue, 6 green; 3 green, 12 red, 3 blue; 5 red, 3 green, 18 blue; 15 blue, 8 red\r\nGame 83: 9 green, 5 blue, 5 red; 8 green, 15 blue, 7 red; 4 green, 6 red, 10 blue; 5 green, 2 red\r\nGame 84: 2 blue, 2 green, 6 red; 2 green, 7 red, 1 blue; 3 green, 3 blue; 2 green, 3 red, 3 blue; 6 green, 4 red\r\nGame 85: 1 blue, 3 green, 5 red; 2 green, 2 red; 4 red, 3 blue; 2 green, 3 blue, 1 red; 4 red, 2 green, 4 blue\r\nGame 86: 6 red, 1 blue; 1 green, 16 red; 2 green, 1 red; 12 red, 1 blue\r\nGame 87: 6 red, 12 green, 1 blue; 5 blue, 6 red, 4 green; 2 blue, 5 red, 8 green\r\nGame 88: 3 green, 6 red, 2 blue; 3 blue, 2 green, 6 red; 1 red, 11 blue, 2 green\r\nGame 89: 7 red, 3 blue, 9 green; 6 red, 3 blue, 15 green; 2 blue, 6 red, 12 green; 5 red, 8 green; 3 blue, 7 red, 9 green; 5 red, 7 green\r\nGame 90: 2 green, 4 red, 19 blue; 13 blue, 4 red, 1 green; 14 blue, 8 green\r\nGame 91: 12 green, 5 blue, 4 red; 9 green, 10 blue, 1 red; 13 green, 1 blue, 4 red; 2 red, 5 blue; 2 blue, 7 green, 2 red; 5 blue, 5 green, 3 red\r\nGame 92: 9 red, 6 blue, 16 green; 11 green, 2 red, 7 blue; 1 green, 1 red, 3 blue; 4 green, 8 red\r\nGame 93: 1 green, 4 blue, 8 red; 2 red, 1 green, 2 blue; 2 blue, 9 red; 1 green, 4 blue, 3 red; 3 red, 1 green, 4 blue\r\nGame 94: 1 green, 7 red, 4 blue; 4 red, 3 blue; 16 blue, 9 red, 7 green; 9 red, 15 blue; 15 blue, 3 red, 6 green; 7 red, 10 blue, 12 green\r\nGame 95: 5 green, 6 blue; 10 green, 9 blue; 4 blue, 8 green, 2 red; 5 blue, 5 green, 1 red\r\nGame 96: 13 blue, 10 red, 2 green; 10 red, 2 green, 1 blue; 6 blue, 5 red, 3 green; 11 red, 3 green, 5 blue; 11 red, 2 green; 3 green, 6 blue\r\nGame 97: 9 green, 11 red, 8 blue; 6 red, 9 blue, 2 green; 3 red, 17 blue, 1 green\r\nGame 98: 14 blue, 3 green; 2 red, 15 blue, 3 green; 15 blue, 8 green, 1 red; 1 red, 8 green\r\nGame 99: 2 green, 7 blue; 14 red, 1 green, 4 blue; 8 blue, 13 red, 2 green; 10 green, 7 red, 10 blue\r\nGame 100: 5 green, 11 blue, 6 red; 5 green, 12 blue; 1 green, 14 blue, 1 red; 3 blue, 5 red, 6 green; 9 blue; 6 red";
            string[] formattedGameData = unformattedGameData.Split("\r\n");
            //iterates through each game (its own line of data)
            foreach (string gameData in formattedGameData)
            {
                Console.WriteLine(gameData);
                bool isPossibleGame = true;
                //removes the game number label leaving the list of colors
                string onlyColors = gameData.Substring(gameData.IndexOf(": ") + 2);
                string[] thisGameDraws = onlyColors.Split("; ");
                while (isPossibleGame)
                {
                    //iterates through the multiple draws of each game
                    foreach (string draw in thisGameDraws)
                    {
                        Console.WriteLine(draw);
                        string[] singleColor = draw.Split(", ");
                        //goes through each color to see if possible
                        foreach (string color in singleColor)
                        {
                            if (!CheckColor(color))
                            {
                                isPossibleGame = false;
                                break;
                            }
                        }
                    }
                    if (!isPossibleGame)
                    {
                        break;
                    }
                    possibleGamesList.Append(gameNumber);
                    sumOfPossibleGames += gameNumber;
                    Console.WriteLine(gameNumber + " is possible");
                    break;
                }
                gameNumber++;
            }
            Console.WriteLine(sumOfPossibleGames);
        }
        static bool CheckColor(string color)
        {
            if (color.Contains("red"))
            {
                int red = int.Parse(color.Substring(0, color.IndexOf(" ")));
                Console.WriteLine(red + " vs 12");
                if (red > 12)
                {
                    Console.WriteLine("red is bigger");
                    return false;
                }
            }
            if (color.Contains("green"))
            {
                int green = int.Parse(color.Substring(0, color.IndexOf(" ")));
                Console.WriteLine(green);
                if (green > 13)
                {
                    Console.WriteLine("green is bigger");
                    return false;
                }
            }
            if (color.Contains("blue"))
            {
                int blue = int.Parse(color.Substring(0, color.IndexOf(" ")));
                Console.WriteLine(blue);
                if (blue > 14)
                {
                    Console.WriteLine("blue is bigger");
                    return false;
                }
            }
            return true;
        }
    }
}