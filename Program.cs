//Here comes the Constructor
using ArrowShop;
List <ArrowParts>alistofarrows=new List <ArrowParts> ();
ArrowParts arrowparts1 = new ArrowParts(0,0,0);
//ArrowParts arrowParts2 = new ArrowParts(3, 2,67);
alistofarrows.Add (arrowparts1);
//alistofarrows.Add (arrowParts2);

foreach (var a in alistofarrows)
{
    Console.WriteLine(a.ToString());
    Console.WriteLine("\n");
}

/*
arrowparts.ArrowHead =Convert.ToInt32( Console.ReadLine());
arrowparts.Fletching = Convert.ToInt32( Console.ReadLine());
arrowparts.Shaft = Convert.ToDouble( Console.ReadLine());
*/



/*
static void Main()
{
   
   int arrowheadtype =Convert.ToInt32( Console.ReadLine());
   int fletchingtype=Convert.ToInt32( Console.ReadLine());
   double Shaft=Convert.ToDouble(Console.ReadLine());
}

Dictionary<int, int> Arrowhead = new Dictionary<int, int>();
{
    Arrowhead.Add(arrowparts.ArrowHead, 10);
    Arrowhead.Add(arrowparts.ArrowHead, 6);
    Arrowhead.Add(arrowparts.ArrowHead, 9);
}
Dictionary<int, int> fletchingtype = new Dictionary<int, int>();
{
    fletchingtype.Add(arrowparts.Fletching, 4);
    fletchingtype.Add(arrowparts.Fletching, 7);
    fletchingtype.Add(arrowparts.Fletching, 5);
}

foreach (KeyValuePair<int, int> a in Arrowhead)
{
    Console.WriteLine("The price of "+a.Value+" is "+a.Value+" Gold");
}
Console.WriteLine("\n");







Console.WriteLine("\n\n");
foreach(KeyValuePair<int, int> b in fletchingtype)
{
    Console.WriteLine("The price of " + b.Key + " is " + b.Value+" Gold");
}
*/