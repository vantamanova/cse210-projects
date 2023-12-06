class Multiplication : Operation 
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Multiplication()
    {
        _operationName = "Multiplication";
        _description = "In math, the meaning of a multiple is the product result of one number multiplied by another number. ";
        _numbType = "Whole";
        _maxNum = 10;
    }
    
    // Used when new element of the class created from the program
    public Multiplication(int duration) : base(duration)
	{
        _operationName = "Multiplication";
        _description = "In math, the meaning of a multiple is the product result of one number multiplied by another number. ";
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
        Console.Write($"{_leftOperand} * {_rightOperand} = ");
        int answer = int.Parse(Console.ReadLine()); 
        return answer;
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_leftOperand * _rightOperand) == answer)
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