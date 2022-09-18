string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
