// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// ----------------------------------------------------------------


/*This code is merely "one possible solution." You could have eliminated the temporary variable flip by calling the Next() inside of the Boolean expression like so:*/

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

