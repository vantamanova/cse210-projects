class Addition : Operation 
{
    // Attributes
    // Constructors
    
    // Used when new element of the class created from the file
    public Addition()
    {
        _operationName = "Addition";
        _description = "In math is a process of combining two or more numbers.\nAddends are the numbers being added, and the result or the final answer we get after the process is called the sum.";
    }

    // Used when new element of the class created from the program
    public Addition(int duration, int score) : base(duration, score)
	{
        _operationName = "Addition";
        _description = "In math is a process of combining two or more numbers.\nAddends are the numbers being added, and the result or the final answer we get after the process is called the sum.";
	}


    // Behaviors
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
}