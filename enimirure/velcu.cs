public class Field
{
    public string Content { get; set; }
}

public class Program
{
    public static void Main()
    {
        Field field = new Field();
        field.Content = "Some text";

        // Reset the content to an empty string
        field.Content = "";
        
        Console.WriteLine($"Field content: '{field.Content}'");  // Output: Field content: ''
    }
}
