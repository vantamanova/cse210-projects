class Division : Operation
{
    // Attributes
    // Constructors
    // Used when new element of the class created from the file
    public Division()
    {
        _operationName = "Division";
        _description = "The operation or process of finding how many equal groups are formed or how many are in each group when sharing fairly.";
    }

    // Used when new element of the class created from the program
    public Division(int duration, int score) : base(duration, score)
	{
        _operationName = "Division";
        _description = "The operation or process of finding how many equal groups are formed or how many are in each group when sharing fairly.";
	}
    // Behaviors
    public override int GetAssignment()
    {
        _leftOperand = GetRandomNumber(_maxNum);
        _rightOperand = GetRandomNumber(_maxNum);

        while (_rightOperand == 0) // 0 division error
        {
            _rightOperand = GetRandomNumber(_maxNum);
        }

        _leftOperand = _leftOperand * _rightOperand; // Getting numbers without remainder
        Console.Write($"{_leftOperand} / {_rightOperand} = ");
        int answer = int.Parse(Console.ReadLine());
        return answer; 
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_leftOperand / _rightOperand) == answer)
        {
            _score += 1;
            return true;
        }
        else return false;
    }
}