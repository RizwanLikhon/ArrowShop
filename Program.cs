using ArrowShop;

//Creating List
List <ArrowParts>alistofarrows=new List <ArrowParts> ();


//Here comes the Constructor
ArrowParts arrowparts1 = new ArrowParts(0,0,0);


//adding into List
alistofarrows.Add (arrowparts1);



//Looping through the list and printing them out
foreach (var a in alistofarrows)
{
    Console.WriteLine(a.ToString());
    Console.WriteLine("\n");
}

