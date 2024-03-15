static double Average(int[] input)
{
    var sum = 0.0;
    for (var i = 0; i < input.Length; i++)
    {
        sum += input[i];
    }

    return sum / input.Length;
}

static int Max(int[] input)
{
    var max = int.MinValue;
    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] > max)
        {
            max = input[i];
        }
    }

    return max;
}

Console.WriteLine("Hello, World!");
Console.WriteLine("zmiana 1");
Console.WriteLine("zmiana 2");
Console.WriteLine("zmiana 3");
var data = new[] { 1, 2, 3, 4 };
Console.WriteLine(Average(data));
Console.WriteLine(Max(data));