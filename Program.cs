internal class Program
{
    private static void Main(string[] args)
    {
        #region First Problem
        Console.WriteLine("Write a Positive number");

        int number = int.Parse(Console.ReadLine());
        int[] numArr = new int[number];


        Console.WriteLine("Write " + number + " count positive number");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Write " + i + 1 + "  number");
            numArr[i] = int.Parse(Console.ReadLine());
        }

        numArr.WriteOnScreen();
        #endregion

        #region Second Problem

        Console.WriteLine("Write two Positive number");

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        num1.GetNCountNumber().WriteOnScreen(num2);

        #endregion

        #region Third Problem

        Console.WriteLine("Write a Positive number");

        int num4 = int.Parse(Console.ReadLine());

        foreach (var item in num4.GetNCountString())
        {
            Console.WriteLine(item);

        }
        #endregion

        #region Fourth Problem

        Console.WriteLine("Write a Sentence");

        string str = Console.ReadLine();

        str.WriteOnScreenCharacterCount();
        str.WriteOnScreenWordCount();

        #endregion

    }
}

public static class Extension
{
    public static void WriteOnScreen(this int[] numArr)
    {
        foreach (var item in numArr)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static int[] GetNCountNumber(this int param)
    {
        int[] numArr = new int[param];

        Console.WriteLine("Write " + param + " count positive number");
        for (int i = 0; i < param; i++)
        {
            Console.WriteLine("Write " + i + 1 + "  number");
            numArr[i] = int.Parse(Console.ReadLine());
        }

        return numArr;
    }

    public static string[] GetNCountString(this int param)
    {
        string[] strArr = new string[param];

        Console.WriteLine("Write " + param + " count word");
        for (int i = 0; i < param; i++)
        {
            Console.WriteLine("Write " + i + 1 + "  word");
            strArr[i] = Console.ReadLine();
        }
        Array.Reverse(strArr);
        return strArr;
    }

    public static void WriteOnScreen(this int[] numArr, int numberM)
    {
        foreach (var item in numArr)
        {
            if (item % numberM == 0 || numberM == item)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static void WriteOnScreenCharacterCount(this string sentence)
    {
        Console.WriteLine(sentence.Replace(" ", "").Length);
    }

    public static void WriteOnScreenWordCount(this string sentence)
    {
        Console.WriteLine(sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);
    }
}