public class MathAssignment : Assignment {
    string _textbookSection;
    string _problems;

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic) {
        _textbookSection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList() {
        string homeWork = $"Section {_textbookSection} Problems {_problems}";
        Console.WriteLine(homeWork);
        return homeWork;
    }
}