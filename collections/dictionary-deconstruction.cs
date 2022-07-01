/*
Did you know ?


A C# Dictionary natively support deconstruction of key value pairs into tuples.


Use this to write more expressive code without additional effort.
*/

var labelToID = new Dictionary<string, int>
{
    ["item1"] = 2022,
    ["item2"] = 1927,
    ["item3"] = 2001,
};

foreach (var (label, id) in labelToID)
{
    Console.WriteLine($"Label = {label}, Id = {id}");
}
