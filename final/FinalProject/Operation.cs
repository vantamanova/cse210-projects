public abstract class Operation
{
    // Attributes
    protected string _operationName;
	protected string _description;
	protected int _score; // can't update to static here because it changes the score for all objects
	protected int _leftOperand;
	protected int _rightOperand;
	protected int _duration;
	protected int _maxNum;

    // Constructors
    public Operation()
	{

	}

	public Operation(int duration, int score)
	{
		_duration = duration;
		_score = score;
		_maxNum = GetMaxNumber(_score);

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

	public static int GetMaxNumber(int score)
	{
		int maxNum = 10;

		if ((score >= 20) && (score < 50))
		{
			maxNum = 20;
		}
		if ((score >= 50) && (score < 100))
		{
			maxNum = 30;
		}

		return maxNum;

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
}