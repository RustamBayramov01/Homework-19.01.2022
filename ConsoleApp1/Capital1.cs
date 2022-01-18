using ConsoleApp1;
using System;



Moskova moskova = new() { PopulationX = 10000, PopulationY = 0 };
Berlin berlin = new() { PopulationX = 200, PopulationY = 0 };


Console.WriteLine(moskova > berlin);
Console.WriteLine(moskova < berlin);