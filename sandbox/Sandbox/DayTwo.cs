class DayTwo
{
    public void RunActivity()
    {
        // Andvent Calendar Day 2

        int answerDay2 = 0;
        string[] lines2 = File.ReadLines("Day_2.txt").ToArray();
        foreach (var line in lines2)
        {
            int gameId = CheckGame(line);
            answerDay2 += gameId;
        }

        Console.WriteLine($"The answer for the Second Day is {answerDay2}");

        static int CheckGame(string line2)
        {
            Game game = new Game();
            bool canPlay = true;

            string[] parts = line2.Split(":"); // Game name
            game._name = parts[0];
            //Console.WriteLine(game._name);

            string[] attempts = parts[1].Split(";"); // Каждая выдача

            foreach (var attempt in attempts)
            {
                //Console.WriteLine(attempt); // Надо проверить каждую выдачу. Не общее количество.

                string[] cubes = attempt.Split(","); // Каждый кубик
                foreach (var cube in cubes)
                {
                    string[] cubeParts = cube.Split(" "); // Цвет и значение кубика

                    int cubeQuontity = int.Parse(cubeParts[1]);
                    string cubeColor = Convert.ToString(cubeParts[2]);

                    if ((cubeColor == "green") & (cubeQuontity > 13))
                    {
                        canPlay = false;
                    }
                    if ((cubeColor == "blue") & (cubeQuontity > 14))
                    {
                        canPlay = false;
                    }
                    if ((cubeColor == "red") & (cubeQuontity > 12))
                    {
                        canPlay = false;
                    }
                }
            }

            // only 12 red cubes, 13 green cubes, and 14 blue cubes
            if (canPlay == false)
            {
                return 0;
            }

            else
            {
                string[] nameParts = game._name.Split(" ");
                int id = int.Parse(nameParts[1]);
                return id;
            }
        }
  
    }
}