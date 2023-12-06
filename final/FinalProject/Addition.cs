class Addition : Operation 
{
    // Attributes
    // Constructors
    
    // Used when new element of the class created from the file
    public Addition()
    {
        _operationName = "Addition";
        _description = "In math is a process of combining two or more numbers. Addends are the numbers being added, and the result or the final answer we get after the process is called the sum.";
        _numbType = "Whole";
        _maxNum = 10;
    }

    // Used when new element of the class created from the program
    public Addition(int duration) : base(duration)
	{
        _operationName = "Addition";
        _description = "In math is a process of combining two or more numbers. Addends are the numbers being added, and the result or the final answer we get after the process is called the sum.";
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
        _leftOperand = GetRandomNumber(_maxNum);
        _rightOperand = GetRandomNumber(_maxNum);
        Console.Write($"{_leftOperand} + {_rightOperand} = ");
        int answer = int.Parse(Console.ReadLine()); 
        return answer;
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_leftOperand + _rightOperand) == answer)
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

    public override string GetStringRepresentation() 
    {
        return ($"{_operationName}:{_score}");
    }
}