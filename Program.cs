// See https://aka.ms/new-console-template for more information
using csharp_calcolatrice;
//SOMMA DI NUMERI INTERI E DECIMALI
Console.WriteLine($"La somma dei numeri è: {helper_CalcoliHelper.sumNumber(5, 8)}");
Console.WriteLine($"La somma dei numeri decimali è: {helper_CalcoliHelper.sumNumberDouble(12.2,5.12)}");

//DIFFERENZA DI NUMERI INTERI E DECIMALI
Console.WriteLine($"Il risultato della divisione è: {helper_CalcoliHelper.divisionNumber(10, 5)}");
Console.WriteLine($"Il risultato della divisione con decimali decimali è: {helper_CalcoliHelper.divisionNumberDouble(10.5, 5)}");

//NUMERI ASSOLUTI INTERI E DECIMALI
Console.WriteLine($"Il numero assoluto è: {helper_CalcoliHelper.absoluteValue(4)}");
Console.WriteLine($"Il numero assoluto è: {helper_CalcoliHelper.absoluteValue(0)}");
Console.WriteLine($"Il numero assoluto è: {helper_CalcoliHelper.absoluteValue(-9)}");
Console.WriteLine($"Il numero assoluto decimale è: {helper_CalcoliHelper.absoluteValue(9.23)}");
Console.WriteLine($"Il numero assoluto decimale è: {helper_CalcoliHelper.absoluteValue(-15.23)}");

//NUMERO MINIMO INTERO E DECIMALE
Console.WriteLine($"Il numero minimo è: {helper_CalcoliHelper.minValue(54, 45)}");
Console.WriteLine($"Il numero minimo decimale è:  {helper_CalcoliHelper.minValue(5.25, 46.38)}");

//NUMERO MASSIMO INTERO E DECIMALE
Console.WriteLine($"Il numero massimo è: {helper_CalcoliHelper.maxValue(15, 89)}");
Console.WriteLine($"Il numero massimo decimale è: {helper_CalcoliHelper.maxValue(46.65, 56.12)}");

