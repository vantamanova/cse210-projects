public class WritingAssignment : Assignment {
    string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic) {
        _title = title;
    }

    public string GetWritingInformation() {
        string info = $"{_title} by {GetStudentName()}";
        Console.WriteLine(info);
        return info;
    }
}