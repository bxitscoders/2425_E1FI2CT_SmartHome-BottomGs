// Die benötigten Bibliotheken verwenden
using System;
using System.IO;

// Einen schreibenden Dateizugriff erstellen
StreamWriter sw = new StreamWriter("./../../../../Test.txt");

// Zeilenweise Text in die Datei schreiben
sw.WriteLine("Hello Echo");
sw.WriteLine("Zweite Zeile");
sw.WriteLine("Dritte Zeile");

// Datei schließen und für andere Anwendungen freigeben.
sw.Close();


// Einen lesenden Dateizugriff erstellen
StreamReader sr = new StreamReader("./../../../../Test.txt");

Console.WriteLine("Hello, World!");

// Die komplette Datei auslesen und an der Konsole ausgeben
Console.WriteLine(sr.ReadToEnd()); // sr.ReadToEnd() liest die "restliche" Datei. Da
                                   // wir bisher noch nichts gelesen haben, die komplette
                                   // Datei

//weitere Optionen
//Console.WriteLine(sr.ReadLine()); // liest die nächste Zeile, in diesem Fall wären wir
                                    //bereits am Ende, als würde es einen "null" (also ein
                                    //leeres Ergebnis, kein leerer String) zurückgeben.
                                    //Wäre die Zeile "Console.WriteLine(sr.ReadToEnd());"
                                    //auskommentiert, würde es hier die erste Zeile des
                                    //Dokumentes zurückgeben. Der nächste gleiche Aufruf
                                    //die zweite Zeile und so weiter.

// Datei schließen und für andere Anwendungen freigeben.
sr.Close();
