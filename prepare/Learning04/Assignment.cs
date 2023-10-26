public class Assignment{
    string _studentName;
    string _topic;

    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary() {
        string summary = $"{_studentName} - {_topic}";
       Console.WriteLine(summary);

       return summary;
    }

    public string GetStudentName(){
        return _studentName;
    }
}