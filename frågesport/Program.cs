using System;


int poäng = 0;

static void poängkoll(int p)
{
    Console.WriteLine($"Du har {p} poäng för nuvarandet");
}
Console.WriteLine("LUCAS FRÅGESPORT");

//-----------------------------------------------------------------------------


Console.WriteLine("Vi börjar lätt, här kommer den första frågan:");
Console.WriteLine("1: Hur lång är jag på en bra dag?");
Console.WriteLine("a) kort b) lång c) rätt svar");
string svar1 = Console.ReadLine();

if (svar1 == "rätt svar")
{
    poäng++;
    Console.WriteLine("Grattis, du hade rätt");
    poängkoll(poäng);

}

else
{
    Console.WriteLine("Du hade fel");
    poängkoll(poäng);
}
//-----------------------------------------------------------------------------

Console.WriteLine("Lite svårare nu");
Console.WriteLine("När är jag född");
Console.WriteLine("a) 31 augusti b) 25 februari c) 1 september");
string svar2 = Console.ReadLine();

if (svar2 == "31 augusti")
{
    poäng++;
    Console.WriteLine("Grattis, du hade rätt");
    poängkoll(poäng);

}

else
{
    Console.WriteLine("Du hade fel");
    poängkoll(poäng);
}

//-----------------------------------------------------------------------------

Console.WriteLine("Nästa fråga:");
Console.WriteLine("Vad gillar jag att göra mest?");
Console.WriteLine("a) spela fotboll b) laga mat c) sjunga i duschen");
string svar3 = Console.ReadLine();

if (svar3 == "laga mat")
{
    poäng++;
    Console.WriteLine("Jag e banger på att laga mat");
    poängkoll(poäng);

}

else
{
    Console.WriteLine("Du hade fel, stelt");
    poängkoll(poäng);
}

//-----------------------------------------------------------------------------

Console.WriteLine("Sista frågan");
Console.WriteLine("Vad heter jag i mellannamn?");
Console.WriteLine("a) jag har inget mellannamn  b) torkel c) jakob");
string svar4 = Console.ReadLine();

if (svar4 == "jag har inget mellannamn")
{
    poäng++;
    Console.WriteLine("Du hade rätt!");
    poängkoll(poäng);

}

else
{
    Console.WriteLine("Mellannamn är overrated, du hade fel!");
    poängkoll(poäng);
}



Console.WriteLine($"Frågesporten är över, du fick {poäng} poäng.");


if (poäng > 3)
{
    Console.WriteLine("Du fick alla rätt, det var väl ait");
}

else
{
    Console.WriteLine("Fett sämst typ, du fick inte ens alla rätt");
}
Console.ReadLine();



