double sayi1, sayi2;
string yapilmakIstenenIslem;
Console.Write("1. sayıyı gir: ");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2.sayıyı gir: ");
sayi2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("yapmak istediğin işlemi gir: ");
yapilmakIstenenIslem = Console.ReadLine();
switch(yapilmakIstenenIslem)
{
    case "+":
        Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
        break;
    case "-":
        Console.WriteLine("Sonuç: " +  (sayi1 - sayi2)); 
        break;
    case "*":
        Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
        break;
    case "/":
        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
        break;
    default:
        Console.WriteLine("yanlış bir tuşa bastın.");
        break;
}


