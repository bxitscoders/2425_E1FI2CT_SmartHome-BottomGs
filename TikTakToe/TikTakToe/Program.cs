// See https://aka.ms/new-console-template for more information
Console.WriteLine("Willkommen bei TikTakToe!");

string[,] felder = new string[3,3];

//Feste Definition der Werte
felder[0,0] = "X";
felder[0,1] = "O";

//Setze alle Felder
for (int zeile = 0; zeile < 3; zeile++)
{
	for (int spalte = 0; spalte < 3; spalte++)
	{
		felder[zeile,spalte] = " ";
	}
}

// Feld setzen David = X; Elias = 0
felder[1,1] = "X";
felder[2, 1] = "O";
felder[0, 2] = "X";
felder[2,0] = "O";
felder[2, 2] = "X";
felder[0,0] = "O";
felder[1,2] = "X";

Console.WriteLine(" -0-1-2-");
Console.WriteLine(" -------");
Console.WriteLine($"0|{felder[0,0]}|{felder[0,1]}|{felder[0,2]}|");
Console.WriteLine(" -------");
Console.WriteLine($"1|{felder[1,0]}|{felder[1,1]}|{felder[1,2]}|");
Console.WriteLine(" -------");
Console.WriteLine($"2|{felder[2,0]}|{felder[2,1]}|{felder[2,2]}|");
Console.WriteLine(" -------");