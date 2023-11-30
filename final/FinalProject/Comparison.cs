class Comparison : Operation 
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Comparison()
    {
        _operationName = "Comparison";
        _description = "A process or method in which one can determine whether a number is smaller, greater, or equal to another number according to their values. ";
        _numbType = "Whole";
        _maxNum = 10; 
    }

    // Used when new element of the class created from the program
    public Comparison(int duration) : base(duration)
	{
        _operationName = "Comparison";
        _description = "A process or method in which one can determine whether a number is smaller, greater, or equal to another number according to their values. ";
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
        
        Console.WriteLine("For '=' press 0 ");
        Console.WriteLine("For '>' press 1 ");
        Console.WriteLine("For '<' press 2 ");

        Console.WriteLine($"{_num1} and {_num2} ");
        int answer = int.Parse(Console.ReadLine());
        Console.WriteLine(); 
        return answer;
    }

    public override bool CheckAssignment(int answer) 
    {
        if ((_num1 == _num2) && (answer == 0))
        {
            _score += 1;
            return true;
        }
        if ((_num1 > _num2) && (answer == 1))
        {
            _score += 1;
            return true;
        }
        if ((_num1 < _num2) && (answer == 2))
        {
            _score += 1;
            return true;
        }
        else return false;
    }
    public override string GetStringRepresentation() // Same for all or not?
    {
        return ($"{_operationName}:{_score}");
    }
}