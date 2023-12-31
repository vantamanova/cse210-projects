class Multiplication : Operation 
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Multiplication()
    {
        _operationName = "Multiplication";
        _description = "In math, the meaning of a multiple is the product result of one number multiplied by another number. ";
    }
    
    // Used when new element of the class created from the program
    public Multiplication(int duration, int score) : base(duration, score)
	{
        _operationName = "Multiplication";
        _description = "In math, the meaning of a multiple is the product result of one number multiplied by another number. ";
	}
    // Behaviors
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
}