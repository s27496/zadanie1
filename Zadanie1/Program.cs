﻿static double Average(int[] input)
{
    var sum = 0.0;
    for (var i = 0; i < input.Length; i++)
    {
        sum += input[i];
    }

    return sum / input.Length;
}

Console.WriteLine("Hello, World!");
Console.WriteLine("zmiana 1");
Console.WriteLine("zmiana 2");
Console.WriteLine("zmiana 3");
var data = new[] { 1, 2, 3, 4 };
Console.WriteLine(Average(data));