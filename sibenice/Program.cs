Random rnd = new Random();
int HadaneCislo;
int vyber;
int hadani;
int NakresleniSibenice = 0;
bool uhodnuti = true;

Console.WriteLine("Pokus se uhodnout číslo v rozmezí 1 až 20.");
Console.ReadLine();
Console.Clear();

HadaneCislo = rnd.Next(1, 21);

while (uhodnuti)
{
    switch (NakresleniSibenice)
    {
        case 1:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  ___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 2:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 3:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 4:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 5:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         O");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 6:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         O");
            Console.WriteLine(" |        /|\\");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 7:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         O");
            Console.WriteLine(" |        /|\\");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        case 8:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         O");
            Console.WriteLine(" |        /|\\");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |        / \\");
            Console.WriteLine(" |");
            Console.WriteLine(" |___");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
        default:
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            break;
    }

    Console.WriteLine("Vyber si:");
    Console.WriteLine("1. Pokusit se uhodnou číslo");
    Console.WriteLine("2. Zjistit více o hádaném číslu");

    vyber = int.Parse(Console.ReadLine());
    switch(vyber)
    {
        case 1:
            Console.WriteLine("Zadej číslo v rozmezí 1 až 20.");

            hadani = int.Parse(Console.ReadLine());
            if (hadani == HadaneCislo)
            {
                uhodnuti = false;
                Console.Clear();
            }
            else
            {
                NakresleniSibenice++;

                Console.WriteLine("Neuhodl jsi.");
                Console.ReadLine();
                Console.Clear();
            }
            break;
        case 2:
            
            break;
    }
}