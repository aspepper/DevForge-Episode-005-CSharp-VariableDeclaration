class Program
{
    static void Main(string[] args)
    {
        // Declaration and assignment of variables
        int age = 51;
        double height = 1.70;
        string name = "Alex Pimenta";
        bool isStudent = true;
        string student = isStudent ? "Yes" : "No";

        // Displaying variable values
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is Student? {student}");
    }
}
