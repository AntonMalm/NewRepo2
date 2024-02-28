public class CalcService
{
    public static int Addition(string first, string second)
    {
        int firstInt = int.Parse(first);
        int secondInt = int.Parse(second);

        return firstInt + secondInt;
    }
    public static int Subtraction(string first, string second)
    {
        int firstInt = int.Parse(first);
        int secondInt = int.Parse(second);

        return firstInt - secondInt;
    }

    public static int Multiplication(string first, string second)
    {
        int firstInt = int.Parse(first);
        int secondInt = int.Parse(second);
        return firstInt * secondInt;
    }
    public static int Division(string first, string second)
    {
        int firstInt = int.Parse(first);
        int secondInt = int.Parse(second);

        return (firstInt / secondInt);
    }

    public void ClearTextbox()
    {
        
    }
}