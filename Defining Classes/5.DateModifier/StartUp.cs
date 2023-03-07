using System;
using System.Linq;
using DateM;

string a = Console.ReadLine();

string b = Console.ReadLine();

DateModifier DateModifier = new DateModifier();

DateModifier.CalcDiff(a, b);

Console.WriteLine(DateModifier.ToString());
