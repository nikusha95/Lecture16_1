// See https://aka.ms/new-console-template for more information


Print("Hello");
await PrintAsync("Hello");

await Task.Factory.StartNew(() => { Console.WriteLine("hello"); });

var r = await SumAsync(1, 2);
//Thread.Sleep(2000);

await Task.Delay(3000);

Console.WriteLine(r);

var res = await SumOfArray(new[] { 1, 2, 3, 4 }, 1);

async Task<int> SumOfArray(int[] arr, int x)
{
    int result = default;
    foreach (var item in arr)
    {
        result += await SumAsync(x, item);
    }

    return result;
}

Task<int> SumAsync(int a, int b)
{
    return Task.FromResult(a + b);
}

Task<int> GetCountEven(int[] arr)
{
    var res = arr.Count(x => x % 2 == 0);

    return Task.FromResult(res);
}

Task PrintAsync(string message)
{
    Console.WriteLine(message);

    return Task.FromResult(message);
}

void Print(string message)
{
    Console.WriteLine(message);

    return;
}