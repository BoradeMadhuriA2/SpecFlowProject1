// Array of strings
string[] strArray = new string[] { "Mahesh", "David", "Allen", "Joe", "Monica" };
Console.WriteLine();
Console.WriteLine("Original array");
foreach (string str in strArray)
{
    Console.Write(str + " ");
}
Console.WriteLine();
// Sort array
Array.Sort(strArray);
// Read array items using foreach loop
foreach (string str in strArray)
{
    Console.Write(str + " ");
}
Console.WriteLine();
Array.Reverse(strArray);
foreach (string str in strArray)
{
    Console.Write(str + " ");
}
Console.WriteLine();


