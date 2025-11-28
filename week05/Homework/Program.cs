using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Assignment Inheritance Demo ===\n");

        // Base class
        Assignment a1 = new Assignment("Jean Ordoñez", "STEM Projects");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        // Math assignment
        MathAssignment m1 = new MathAssignment(
            "Ana",
            "Linear Equations",
            "7.3",
            "8-19"
        );

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        // Writing assignment
        WritingAssignment w1 = new WritingAssignment(
            "Luis",
            "Peruvian History",
            "How STEM is Transforming Education in Huancavelica"
        );

        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine();
    }
}
