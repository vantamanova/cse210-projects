public abstract class Operation
{
    // Attributes
    protected string _operationName;
	protected string _description;
	protected string _numbType;
	protected int _score; 
	protected int _num1;
	protected int _num2;
	protected int _maxNum;
	protected int _duration;
	protected int _level;

    // Constructors
    public Operation()
	{

	}

	public Operation(int duration)
	{
		_duration = duration;

	}
    
    // Behaviors
	public abstract void ShowDescription();
	public abstract int GetAssignment();
	public abstract bool CheckAssignment(int answer);
	public static int GetRandomNumber(int maxNum)
	{
		Random rnd = new Random();
        int number = rnd.Next(0, maxNum);
		return number;
	}

	public abstract string GetStringRepresentation();
	public void LoadProgress(string progress)
	{
		_score = int.Parse(progress);
	}
	
	// Getters and Setters
	public int GetScore()
	{
		return _score;
	}

	public void SetScore(int score)
	{
		_score = score;
	}

	public string GetName()
	{
		return _operationName;
	}

	public int GetDuration()
	{
		return _duration;
	}
	
	public int GetLevel()
	{
		return _level;
	}
}