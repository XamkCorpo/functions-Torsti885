using System.ComponentModel.Design;

string laskutoimitus = valitselaskutoimitus();
int ensimmäinenluku = kysyensimmäinenluku();
int toinenluku = kysytoinenluku();
int summa = ensimmäinenluku + toinenluku;
int erotus = ensimmäinenluku - toinenluku;
double tulo = ensimmäinenluku * toinenluku;
double jako = ensimmäinenluku / toinenluku;


/// Tulostetaan laskutoimitus ja tulos käyttäjän valinnan mukaan.
while (true)
{
    if(laskutoimitus == "+")
    {
        
        Console.WriteLine($"{ensimmäinenluku} {laskutoimitus} {toinenluku} = {summa}");
        break;
    }
    else if (laskutoimitus == "-")
    {
        Console.WriteLine($"{ensimmäinenluku} {laskutoimitus} {toinenluku} = {erotus}");
        break;
    }
    else if (laskutoimitus == "*")
    {
        Console.WriteLine($"{ensimmäinenluku} {laskutoimitus} {toinenluku} = {tulo}");
        break;
    }
    else if (laskutoimitus == "/")
    {
        Console.WriteLine($"{ensimmäinenluku} {laskutoimitus} {toinenluku} = {jako}");
        break;
    }
    

}


/// Funktio kysyy käyttäjältä mikä lasku lasketaan ja palauttaa sen.
string valitselaskutoimitus()
{
    Console.Write("Valitse laskutoimitus (+, -, *, /): ");
    string? input = Console.ReadLine();
    while (true)
    {

        if (input == "+" || input == "-" || input == "*" || input == "/")
            return input;
        Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");


    }



}

/// Funktio kysyy käyttäjältä ensimmäisen luvun ja palauttaa sen.
int kysyensimmäinenluku()
{
    while (true)
    {
        Console.Write("Syötä ensimmäinen luku: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
            return number;
        Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
    }
}

/// Funktio kysyy käyttäjältä toisen luvun ja palauttaa sen.
int kysytoinenluku()
{
    while (true)
    {
        Console.Write("Syötä toinen luku: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
            return number;
        Console.WriteLine("Virheellinen syöte. Yritä uudelleen.");
    }
}
        
