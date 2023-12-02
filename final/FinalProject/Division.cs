class Division : Operation
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Division()
    {
        _operationName = "Division";
        _description = "The operation or process of finding how many equal groups are formed or how many are in each group when sharing fairly.";
        _numbType = "Whole";
        _maxNum = 10;
    }

    // Used when new element of the class created from the program
    public Division(int duration) : base(duration)
	{
        _operationName = "Division";
        _description = "The operation or process of finding how many equal groups are formed or how many are in each group when sharing fairly.";
        _numbType = "Whole";
        _maxNum = 10;
	}
    // Behaviors
    public override void ShowDescription() // Will put it into parent class if there will be nothing else (like example)
    {
        Console.WriteLine($"{_operationName}: {_description}");
    }

    public override int GetAssignment()
    {
        _num1 = GetRandomNumber(_maxNum);
        _num2 = GetRandomNumber(_maxNum);

        while (_num2 == 0) // 0 division error
        {
            _num2 = GetRandomNumber(_maxNum);
        }

        _num1 = _num1 * _num2; // Getting numbers without remainder
        Console.Write($"{_num1} / {_num2} = ");
        int answer = int.Parse(Console.ReadLine());
        return answer; 
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_num1 / _num2) == answer)
        {
            _score += 1;
            return true;
        }
        else return false;
    }

    public override int CalculatePoints()
    {
        return 0;
    }

    public override string GetStringRepresentation()  // Same for all or not?
    {
        return ($"{_operationName}:{_score}");
    }
}