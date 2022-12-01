using static System.Console;
namespace FuncLib;

public class Func
{
    public string[] GetStrArr(string input)
    {
        string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] result = new string[array.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i];
        }
        return result;
    }

    public string[] CutStrArr(string[] array, int length)
    {
        string[] result = new string[length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[new Random().Next(array.Length)];
        }

        return result;
    }
}
