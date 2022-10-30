
using System.Numerics;
using System;
using System.Collections.Generic;
using ListOfObjects;

List<Player> players = new List<Player>();

players.Add(new Player("Chad"));
players.Add(new Player("Steve"));
players.Add(new Player("Karen"));

foreach (Player player in players)
{
    Console.WriteLine(player);
}

