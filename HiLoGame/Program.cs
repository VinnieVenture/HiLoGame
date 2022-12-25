using HiLoGame;

Console.WriteLine("Witaj w HiLo.");
Console.WriteLine($"Odgadnij liczbę od 1 do {HiLoGameMecanic.MAXIMUM }.");
HiLoGameMecanic.Hint();
while (HiLoGameMecanic.GetPot() > 0)
{
    Console.WriteLine("Wciśnij w (większa), m (mniejsza) lub ? (kupno wskazówki).");
    Console.WriteLine($"Inne klawisze to koniec gry z {HiLoGameMecanic.GetPot()}zł.");
    char key = Console.ReadKey(true).KeyChar;
    if (key == 'w') HiLoGameMecanic.Guess(true);
    else if (key == 'm') HiLoGameMecanic.Guess(false);
    else if (key == '?') HiLoGameMecanic.Hint();
    else return;
}
Console.WriteLine("Skończyły Ci się pieniądze do zobaczenia!");