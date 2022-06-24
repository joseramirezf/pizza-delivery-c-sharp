Console.WriteLine("Pizza Delivery");

Console.WriteLine("Enter a Number of Pizzas");
int pizzas = Int32.Parse(Console.ReadLine() ?? "n");

Console.WriteLine("Enter Size (large / medium / small)");
string size = Console.ReadLine() ?? "n";

Console.WriteLine("Enter a Number of Person");
int person = Int32.Parse(Console.ReadLine() ?? "n");


if (size == "large")
{
     int slices = pizzas * 16 / person;
     Console.WriteLine("Number of slices per person:" + slices);
     int leftovers = pizzas * 16 % person;
     Console.WriteLine("Remaining slices:" + leftovers);
     
} else {
    if (size == "medium")
{
     int slices = pizzas * 12 / person;
     Console.WriteLine("Number of slices per person:" + slices);
     int leftovers = pizzas * 12 % person;
     Console.WriteLine("Remaining slices:" + leftovers);
} else {
    int slices = pizzas * 8 / person;
     Console.WriteLine("Number of slices per person:" + slices);
     int leftovers = pizzas * 8 % person;
     Console.WriteLine("Remaining slices:" + leftovers);
}
}
