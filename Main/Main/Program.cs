using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static string botPrefix = "[BOT] > ";
        static string triggerString = ".";
        const string s = "s";
        const string u = "u";
        const string v = "v";
        const string a = "a";
        const string t = "t";
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string rawInput = Console.ReadLine();
                    string[] commandArgs = rawInput.Split(' ');
                    if (commandArgs[0].StartsWith(triggerString))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        switch (commandArgs[0].ToLower().Remove(0, triggerString.Length))
                        {
                            case a:
                                {
                                    Dictionary<string, decimal> varDict = new Dictionary<string, decimal>();
                                    string[] setVars = { s, v, t, u };
                                    string missingVar = "";
                                    int missingVars = 0;
                                    foreach (string singleVar in setVars)
                                    {
                                        Console.Write(singleVar + ": ");
                                        string tempStore = Console.ReadLine();
                                        if (tempStore.Length == 0)
                                        {
                                            missingVar = singleVar;
                                            missingVars++;
                                        }
                                        else
                                        {
                                            varDict.Add(singleVar, decimal.Parse(tempStore));
                                        }
                                    }
                                    if (missingVars == 1)
                                    {
                                        decimal result = 0;
                                        switch (missingVar)
                                        {
                                            case s:
                                                {
                                                    result = (decimal)0.5 * (varDict[u] + varDict[v]) * varDict[t];
                                                    Console.WriteLine("(({0} + {1}) * {2}) / 2", varDict[u], varDict[v], varDict[t]);
                                                }
                                                break;
                                            case v:
                                                {
                                                    result = ((decimal)2 * varDict[s] / varDict[t]) - varDict[u];
                                                    Console.WriteLine("(2 * {0} / {1}) - {2}", varDict[s], varDict[t], varDict[u]);
                                                }
                                                break;
                                            case t:
                                                {
                                                    result = ((decimal)2 * varDict[s]) / (varDict[u] + varDict[v]);
                                                    Console.WriteLine("(2 * {0}) / ({1} + {2})", varDict[s], varDict[u], varDict[v]);
                                                }
                                                break;
                                            case u:
                                                {
                                                    result = ((decimal)2 * varDict[s] / varDict[t]) - varDict[v];
                                                    Console.WriteLine("(2 * {0} / {1}) - {2}", varDict[s], varDict[t], varDict[v]);
                                                }
                                                break;
                                        }
                                        Console.WriteLine(missingVar + ": " + result.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can only have one missing variable");
                                    }
                                }
                                break;
                            case s:
                                {
                                    Dictionary<string, decimal> varDict = new Dictionary<string, decimal>();
                                    string[] setVars = { a, v, t, u };
                                    string missingVar = "";
                                    int missingVars = 0;
                                    foreach (string singleVar in setVars)
                                    {
                                        Console.Write(singleVar + ": ");
                                        string tempStore = Console.ReadLine();
                                        if (tempStore.Length == 0)
                                        {
                                            missingVar = singleVar;
                                            missingVars++;
                                        }
                                        else
                                        {
                                            varDict.Add(singleVar, decimal.Parse(tempStore));
                                        }
                                    }
                                    if (missingVars == 1)
                                    {
                                        decimal result = 0;
                                        switch (missingVar)
                                        {
                                            case a:
                                                {
                                                    result = (varDict[v] - varDict[u]) / varDict[t];
                                                    Console.WriteLine("({0} - {1}) / {2}", varDict[v], varDict[u], varDict[t]);
                                                }
                                                break;
                                            case v:
                                                {
                                                    result = varDict[u] + (varDict[a] * varDict[t]);
                                                    Console.WriteLine("{0} + ({1} * {2})", varDict[u], varDict[a], varDict[t]);
                                                }
                                                break;
                                            case t:
                                                {
                                                    result = (varDict[v] - varDict[u]) / varDict[a];
                                                    Console.WriteLine("({0} - {1}) / {2}", varDict[v], varDict[u], varDict[a]);
                                                }
                                                break;
                                            case u:
                                                {
                                                    result = varDict[v] - (varDict[a] * varDict[t]);
                                                    Console.WriteLine("{0} - ({1} * {2})", varDict[v], varDict[a], varDict[t]);
                                                }
                                                break;
                                        }
                                        Console.WriteLine(missingVar + ": " + result.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can only have one missing variable");
                                    }
                                }
                                break;
                            case v:
                                {
                                    Dictionary<string, decimal> varDict = new Dictionary<string, decimal>();
                                    string[] setVars = { a, s, t, u };
                                    string missingVar = "";
                                    int missingVars = 0;
                                    foreach (string singleVar in setVars)
                                    {
                                        Console.Write(singleVar + ": ");
                                        string tempStore = Console.ReadLine();
                                        if (tempStore.Length == 0)
                                        {
                                            missingVar = singleVar;
                                            missingVars++;
                                        }
                                        else
                                        {
                                            varDict.Add(singleVar, decimal.Parse(tempStore));
                                        }
                                    }
                                    if (missingVars == 1)
                                    {
                                        decimal result = 0;
                                        switch (missingVar)
                                        {
                                            case a:
                                                {
                                                    result = ((decimal)2 * (varDict[s] - (varDict[u] * varDict[t]))) / (varDict[t] * varDict[t]);
                                                    Console.WriteLine("(2 * ({0} - ({1} * {2}))) / {2}^2", varDict[s], varDict[u], varDict[t]);
                                                }
                                                break;
                                            case s:
                                                {
                                                    result = (varDict[u] * varDict[t]) + ((decimal)0.5 * varDict[a] * varDict[t] * varDict[t]);
                                                    Console.WriteLine("({0} * {1}) + ({2}*{1}^2)/2", varDict[u], varDict[t], varDict[a]);
                                                }
                                                break;
                                            case t:
                                                {
                                                    try
                                                    {
                                                        decimal result_1 = ((((decimal)-1) * varDict[u]) + (decimal)(Math.Sqrt((double)((varDict[u] * varDict[u]) + ((decimal)2 * varDict[s] * varDict[a]))))) / varDict[a];
                                                        decimal result_2 = ((((decimal)-1) * varDict[u]) - (decimal)(Math.Sqrt((double)((varDict[u] * varDict[u]) + ((decimal)2 * varDict[s] * varDict[a]))))) / varDict[a];
                                                        Console.WriteLine("t1: " + result_1.ToString());
                                                        Console.WriteLine("t2: " + result_2.ToString());
                                                    }
                                                    catch { }
                                                }
                                                break;
                                            case u:
                                                {
                                                    result = (varDict[s] - ((decimal)0.5 * varDict[a] * (varDict[t] * varDict[t]))) / varDict[t];
                                                    Console.WriteLine("({0} - (({1} * {2}^2) / 2)) / {2}", varDict[s], varDict[a], varDict[t]);
                                                }
                                                break;
                                        }
                                        Console.WriteLine(missingVar + ": " + result.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can only have one missing variable");
                                    }
                                }
                                break;
                            case t:
                                {
                                    Dictionary<string, decimal> varDict = new Dictionary<string, decimal>();
                                    string[] setVars = { a, s, v, u };
                                    string missingVar = "";
                                    int missingVars = 0;
                                    foreach (string singleVar in setVars)
                                    {
                                        Console.Write(singleVar + ": ");
                                        string tempStore = Console.ReadLine();
                                        if (tempStore.Length == 0)
                                        {
                                            missingVar = singleVar;
                                            missingVars++;
                                        }
                                        else
                                        {
                                            varDict.Add(singleVar, decimal.Parse(tempStore));
                                        }
                                    }
                                    if (missingVars == 1)
                                    {
                                        decimal result = 0;
                                        switch (missingVar)
                                        {
                                            case a:
                                                {
                                                    result = ((varDict[v] * varDict[v]) - (varDict[u] * varDict[u])) / ((decimal)2 * varDict[s]);
                                                    Console.WriteLine("({0}^2 - {1}^2) / (2 * {2})", varDict[v], varDict[u], varDict[s]);
                                                }
                                                break;
                                            case s:
                                                {
                                                    result = ((varDict[v] * varDict[v]) - (varDict[u] * varDict[u])) / ((decimal)2 * varDict[a]);
                                                    Console.WriteLine("({0}^2 - {1}^2) / (2 * {2})", varDict[v], varDict[u], varDict[a]);
                                                }
                                                break;
                                            case v:
                                                {
                                                    result = (decimal)Math.Sqrt((double)((varDict[u] * varDict[u]) + ((decimal)2 * varDict[a] * varDict[s])));
                                                    Console.WriteLine("sqrt({0}^2 + (2 * {1} * {2}))", varDict[u], varDict[a], varDict[s]);
                                                }
                                                break;
                                            case u:
                                                {
                                                    result = (decimal)Math.Sqrt((double)((varDict[v] * varDict[v]) - ((decimal)2 * varDict[a] * varDict[s])));
                                                    Console.WriteLine("sqrt({0}^2 - (2 * {1} * {2}))", varDict[v], varDict[a], varDict[s]);
                                                }
                                                break;
                                        }
                                        Console.WriteLine(missingVar + ": " + result.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can only have one missing variable");
                                    }
                                }
                                break;
                            case u:
                                {
                                    Dictionary<string, decimal> varDict = new Dictionary<string, decimal>();
                                    string[] setVars = { a, s, v, t };
                                    string missingVar = "";
                                    int missingVars = 0;
                                    foreach (string singleVar in setVars)
                                    {
                                        Console.Write(singleVar + ": ");
                                        string tempStore = Console.ReadLine();
                                        if (tempStore.Length == 0)
                                        {
                                            missingVar = singleVar;
                                            missingVars++;
                                        }
                                        else
                                        {
                                            varDict.Add(singleVar, decimal.Parse(tempStore));
                                        }
                                    }
                                    if (missingVars == 1)
                                    {
                                        decimal result = 0;
                                        switch (missingVar)
                                        {
                                            case a:
                                                {
                                                    result = ((decimal)2 * (varDict[s] - (varDict[v] * varDict[t]))) / (((decimal)-1) * (varDict[t] * varDict[t]));
                                                    Console.WriteLine("(-2 * ({0} - ({1} * {2}))) / {2}^2", varDict[s], varDict[v], varDict[t]);
                                                }
                                                break;
                                            case s:
                                                {
                                                    result = (varDict[v] * varDict[t]) - ((decimal)0.5 * varDict[a] * varDict[t] * varDict[t]);
                                                    Console.WriteLine("({0} * {1}) - (({2} * {1}^2) / 2)", varDict[v], varDict[t], varDict[a]);
                                                }
                                                break;
                                            case v:
                                                {
                                                    result = (varDict[s] + ((decimal)0.5 * varDict[a] * varDict[t] * varDict[t])) / varDict[t];
                                                    Console.WriteLine("({0} + (({1} * {2}^2)/2)) / {2}", varDict[s], varDict[a], varDict[t]);
                                                }
                                                break;
                                            case t:
                                                {
                                                    try
                                                    {
                                                        decimal result_1 = (varDict[v] + (decimal)Math.Sqrt((double)((varDict[v] * varDict[v]) - ((decimal)2 * varDict[s] * varDict[a]))));
                                                        decimal result_2 = (varDict[v] - (decimal)Math.Sqrt((double)((varDict[v] * varDict[v]) - ((decimal)2 * varDict[s] * varDict[a]))));
                                                        Console.WriteLine("t1: " + result_1.ToString());
                                                        Console.WriteLine("t2: " + result_2.ToString());
                                                    }
                                                    catch { }
                                                }
                                                break;
                                        }
                                        Console.WriteLine(missingVar + ": " + result.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can only have one missing variable");
                                    }
                                }
                                break;
                            case "help":
                                if (true)
                                {
                                    Console.WriteLine(botPrefix + "Valid commands are "
                                        + Environment.NewLine + "    " + triggerString + "a - Missing acceleration"
                                        + Environment.NewLine + "    " + triggerString + "s - Missing displacement"
                                        + Environment.NewLine + "    " + triggerString + "v - Missing final velocity"
                                        + Environment.NewLine + "    " + triggerString + "t - Missing time"
                                        + Environment.NewLine + "    " + triggerString + "u - Missing initial velocity"
                                        );
                                }
                                break;
                            default:
                                if (true)
                                {
                                    Console.WriteLine(botPrefix + "Invalid command. View commands with " + triggerString + "help");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(0, (rawInput.Length + 1 > Console.WindowWidth) ? Console.CursorTop - (Convert.ToInt32(((decimal)((rawInput.Length + 1) / Console.WindowWidth)).ToString().Split('.')[0]) + 1) : Console.CursorTop - 1);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(rawInput);
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
