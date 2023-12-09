class Subtraction : Operation 
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Subtraction()
    {
        _operationName = "Subtraction";
        _description = "The operation or process of finding the difference between two numbers or quantities is known as subtraction.";
    }
    
    // Used when new element of the class created from the program
    public Subtraction(int duration, int score) : base(duration, score)
	{
        _operationName = "Subtraction";
        _description = "The operation or process of finding the difference between two numbers or quantities is known as subtraction.";
	}
    // Behaviors
    public override int GetAssignment()
    {
        _leftOperand = GetRandomNumber(_maxNum);
        _rightOperand = GetRandomNumber(_maxNum);
        Console.Write($"{_leftOperand} - {_rightOperand} = ");
        int answer = int.Parse(Console.ReadLine());
        return answer; 
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_leftOperand - _rightOperand) == answer)
        {
            _score += 1;
            return true;
        }
        else return false;
    }
}