class Multiplication : Operation 
{
    // Attributes
    // Constructors
    public Multiplication()
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
        _num1 = GetRandomNumber(_maxNum);
        _num2 = GetRandomNumber(_maxNum);
        Console.Write($"{_num1} * {_num2} = ");
        int answer = int.Parse(Console.ReadLine()); 
        return answer;
    }

    public override bool CheckAssignment(int answer)
    {
        if ((_num1 * _num2) == answer)
        {
            _score += 1;
            return true;
        }
        else return false;
    }

    public override string GetStringRepresentation()  // Same for all or not?
    {
        return ($"{_operationName}:{_score}");
    }
}