using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

Console.WriteLine("Welcome to the Grocery store!");
//write dictionary 8 items 8 prices
Dictionary<string, decimal> itemStock = new Dictionary<string, decimal>();
itemStock.Add("banana", 1.00m);
itemStock.Add("apple", 1.50m);
itemStock.Add("orange", 1.40m);
itemStock.Add("steak", 1.30m);
itemStock.Add("bread", 1.20m);
itemStock.Add("pepsi", 1.10m);
itemStock.Add("coke", 1.15m);
itemStock.Add("fish", 1.35m);

decimal total = 0.00m;
//display dictionary
foreach (KeyValuePair<string, decimal> kvp in itemStock)
{
    Console.WriteLine($"{kvp.Key}, {kvp.Value}");
}
 List<string> cart = new List<string>();
//Dictionary<string, decimal> maxMin = new Dictionary<string, decimal>();


bool runProgram = true;
while (runProgram = true)
{
    Console.WriteLine("Would you like to add an item? y/n");
    string yesNo = Console.ReadLine().ToLower().Trim();
    if (yesNo == "y")
    {
        int i = 0;
        while (i == 0)
        {
            //ask user to enter an item name. then display item and price ----- if that item name doesnt exist, display error and re-prompt
            Console.WriteLine("Please enter the item you wish to buy.");
            string choice = Console.ReadLine().ToLower();
            bool itemCheck = itemStock.ContainsKey(choice);
            if (itemCheck == true)
            {
                decimal price = (decimal)itemStock[choice];
                Console.Write($"{choice} ");
                Console.Write($"${price} ");
                Console.WriteLine($" Your item has been added!");

                cart.Add(choice);
                //maxMin.Add(choice, price);

                total = total + price;
                i++;

            }
            else
            {
                Console.WriteLine("We do not carry that item.");
                i = 0;

            }
            runProgram = true;
        }
    }
    else if (yesNo == "n")
    {
        //shopping list display back
        foreach (string c in cart)
        {
            Console.WriteLine($"{c} {itemStock[c]}");
        }
        decimal average = total / (cart.Count);
        decimal avgRound = Math.Round(average, 2);
        //decimal
        Console.WriteLine($"Your average item price is {avgRound}.");
        //total price
        Console.WriteLine($"Your total is ${total}");


        //Console.WriteLine($"Your least expensive item is {}");
       //Console.WriteLine($"Your most expensive item is");
        //Console.WriteLine($"");
        runProgram = false;
        break;

        
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}

Console.ReadLine();




//when done shopping display their new list of items in shopping cart


//display sum of price 



//Key              value



