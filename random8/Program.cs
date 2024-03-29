﻿// See https://aka.ms/new-console-template for more information

Random random = new Random();

string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
int numFruits = 3;
string[] randomFruits = random.GetItems(fruits, numFruits);

Console.WriteLine($"Randomly selected {numFruits} fruits: {{ {string.Join(", ", randomFruits)} }}");

string[] names = ["John", "Mary", "Bob","Jim", "Tim","Rick"];
int numNames = 25;
var randomNames = random.GetItems(names,25);
Console.WriteLine($"Randomly selected {numNames} names: {{ {string.Join(", ", randomNames)} }}");
random.Shuffle(randomNames);

Console.WriteLine($"Randomly selected {numNames} names: {{ {string.Join(", ", randomNames)} }}");

var dog = random.Next(1, 100);
Console.WriteLine($"Randomly picked a new number: {{ {string.Join(", ", dog)} }}");
