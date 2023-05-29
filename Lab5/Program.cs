using Lab5;

var collection = new MyCollection();

var enumerator = collection.GetEnumerator();

while (enumerator.MoveNext())
{
    object item = enumerator.Current;
    Console.WriteLine(item);
}

Console.WriteLine("use foreach");

foreach (var item in collection)
{
    Console.WriteLine(item);
}