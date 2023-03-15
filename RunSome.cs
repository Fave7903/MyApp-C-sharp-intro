using Humanizer;

class RunSome {
    public string Name { get; set; }
    private int num;
    public int Num {
        get { return num; }
        set { num = value; }
    }
    public void Output() {
        Console.WriteLine($"This is the number: {num.ToWords()}");
    }
}