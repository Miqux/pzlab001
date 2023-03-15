using pzlab01;

Firm firm = new Firm();
var temp = 0;
while (temp != 7)
{
    firm.DisplayMenuOptions();
    try
    {        
        temp = Int32.Parse(Console.ReadLine());
        Console.Clear();
    }
    catch 
    {
        Console.WriteLine("Wprowadzono nieprawidłowy znak");
    }
    firm.Menu(temp);    
}
