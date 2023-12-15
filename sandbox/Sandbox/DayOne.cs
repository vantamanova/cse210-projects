class DayOne
{
    public void RunActivity()
    {
        // Advent Calendar Day 1

        string fileName = "Day_1.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int answer = 0;

        foreach (string line in lines)
        {
            answer = answer + GetNumbers(line);
        }

        Console.WriteLine($"The answer for the First Day is {answer}");

        static int GetNumbers(string line) // Gets numbers from the string, returns List
        {
            List<int> numbers = new List<int>();
            char[] valueArr = line.ToCharArray();

            foreach (var x in valueArr)
            {
                if (Char.IsDigit(x) == true)
                    {
                        int number = x - '0';
                        numbers.Add(number);
                    }
            }

            int numSum = int.Parse(numbers.First().ToString() + numbers.Last().ToString());
            return numSum;
        }        
    }
}