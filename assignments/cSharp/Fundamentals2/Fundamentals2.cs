// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// THREE BASIC ARRAYS
// Create an integer array with the values 0 through 9 inside. 
int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };


// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code values in)
bool[] boolArray = new bool[10];
for (int i = 0; i < boolArray.Length; i++)
{
    if (i % 2 == 0)
    {
        boolArray[i] = true;
    }
    else
    {
        boolArray[i] = false;
    }
    Console.WriteLine(boolArray[i]);
}



// LIST OF FLAVORS
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5)
List<string> iceCreamFlavors = new List<string>();
iceCreamFlavors.Add("Chocolate");
iceCreamFlavors.Add("Rocky Road");
iceCreamFlavors.Add("Red Velvet");
iceCreamFlavors.Add("Coffee");
iceCreamFlavors.Add("Cookie Dough");


// Output the length of the list after you added the flavors. 
Console.WriteLine($"List length: {iceCreamFlavors.Count}");


// Output the third flavor in the list
Console.WriteLine(iceCreamFlavors[2]);


// Now remove the third flavor using its index location.
iceCreamFlavors.RemoveAt(2);

for (int x = 0; x < iceCreamFlavors.Count; x++)
{
    Console.WriteLine(iceCreamFlavors[x]);
}


// Output the length of the list again. It should now be one fewer. 
Console.WriteLine($"List length: {iceCreamFlavors.Count}");


// USER DICTIONARY
// Create a dictionary that will store string keys and string values
Dictionary<string, string> favoriteIceCream = new Dictionary<string, string>();


// Add key/value pairs to the dictionary where:

// Random rand = new Random();
// static void getRand() {
// int theRand = rand.Next(iceCreamFlavors.Count);
// tempValue = iceCreamFlavors[theRand];
// }

// string tempValue = "temp";
// combo.Add(names[0], getRand());
// Console.WriteLine(combo[0]);


//Random rand = new Random();
// NameandFlav.Add ("Tim", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Martin", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Nikki", iceCreamFlav[rand.Next(6)]);
// NameandFlav.Add ("Sara", iceCreamFlav[rand.Next(6)]);


// Console.WriteLine(NameandFlav["Tim"]);

// - Each key is a name from your names array (this can be done by hand or using logic)
// - Each value is a randomly selected flavor from your flavors list (remember Random from earlier?)
Random rand = new Random();
for (int i = 0; i < nameArray.Length; i++)
{
    favoriteIceCream.Add(nameArray[i], iceCreamFlavors[rand.Next(0, iceCreamFlavors.Count)]);
}


// Loop through the dictionary and print out each user's name and their associated ice cream flavor. 

foreach (KeyValuePair<string, string> flavor in favoriteIceCream)
{
    Console.WriteLine($"{flavor.Key} - {flavor.Value}");
}