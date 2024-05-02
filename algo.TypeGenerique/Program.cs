using algo.TypeGenerique;

ClassGeneric<int> c = new(5,4);

Console.WriteLine(c);
Console.WriteLine(c.Sum());

ClassGeneric<string> c2 = new("test","test2");

Console.WriteLine(c2);
Console.WriteLine(c2.Sum());