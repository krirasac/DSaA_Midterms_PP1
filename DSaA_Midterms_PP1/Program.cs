using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA_Midterms_PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> info = new Dictionary<string, string[]>();
            string id; bool run = true;

            while (run)
            {
                //main menu
                Console.WriteLine("\n+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");
                Console.WriteLine($"       There are currently {info.Count} entry(s) in the dictionary.");
                Console.WriteLine("+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("[A] Add Entry\n[B] Update Entry\n[C] View Entry\n[D] View All\n[E] Delete Entry\n[F] Quit");
                Console.Write("\nANSWER:\t");
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();

                switch (userInput)
                {
                    case "a": //add in a new entry

                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine("   ADD AN ENTRY");
                        Console.WriteLine("+--+--+--+--+--+--+");

                        Console.WriteLine("\nPlease input the following information\n");
                        Console.Write("ID:\t");
                        userInput = Console.ReadLine();
                        info[id = userInput] = new string[4];
                        Console.Write("LAST NAME\t:\t");
                        info[id][0] = Console.ReadLine();
                        Console.Write("FIRST NAME\t:\t");
                        info[id][1] = Console.ReadLine();
                        Console.Write("EMAIL ADD.\t:\t");
                        info[id][2] = Console.ReadLine();
                        Console.Write("CONTACT NO.\t:\t");
                        info[id][3] = Console.ReadLine();

                        Console.WriteLine($"\nEntry [{userInput}] has been added to the Dictionary!");
                        Console.ReadKey();

                        Console.Clear();
                        break;

                    case "b": //update an entry

                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine("  UPDATE AN ENTRY");
                        Console.WriteLine("+--+--+--+--+--+--+");

                        if (info.Count != 0)
                        {
                            Console.Write("\nPlease input the ID that you want to update:\t");
                            userInput = Console.ReadLine();

                            if (info.ContainsKey(userInput))
                            {
                                //displays the information
                                Console.WriteLine($"\nEntry {userInput} has been found!\n");
                                Console.WriteLine($"1. LAST NAME\t: {info[userInput][0]}");
                                Console.WriteLine($"2. FIRST NAME\t: {info[userInput][1]}");
                                Console.WriteLine($"3. EMAIL ADD.\t: {info[userInput][2]}");
                                Console.WriteLine($"4. CONTACT NO.\t: {info[userInput][3]}");

                                //allows the user to make changes on certain info
                                Console.WriteLine("\nPlease type in the updated info. Leave it blank if there are no changes.\n");

                                for (int i = 0; i < info[userInput].Length; i++)
                                {
                                    Console.Write($"{i + 1}. \t");
                                    string temp = Console.ReadLine();

                                    if (temp != "")
                                    {
                                        info[userInput][i] = temp;
                                    }

                                }

                                Console.WriteLine($"\nEntry [{userInput}] has been updated!");
                                Console.ReadKey();

                            }
                            else //if entry is invalid
                            {
                                Console.WriteLine($"\nEntry [{userInput}] is not found");
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        else //if there are no entries
                        {
                            Console.WriteLine("\nThere are no entries to update.\nPress any key to continue...");
                            Console.ReadKey();
                        }

                        Console.Clear();
                        break;

                    case "c": // view an entry

                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine("   VIEW AN ENTRY");
                        Console.WriteLine("+--+--+--+--+--+--+");

                        if (info.Count != 0)
                        {
                            Console.WriteLine("\nChoose which method to search:\n[A] ID\n[B] SURNAME");
                            Console.Write("\nAnswer:\t");
                            userInput = Console.ReadLine().ToLower();

                            if (userInput == "a")
                            {
                                Console.Write("\nPlease input the ID that you want to view:\t");
                                userInput = Console.ReadLine();

                                if (info.ContainsKey(userInput))
                                {
                                    Console.WriteLine("\nEntry has been found!\n");
                                    Console.WriteLine($"LAST NAME\t: {info[userInput][0]}");
                                    Console.WriteLine($"FIRST NAME\t: {info[userInput][1]}");
                                    Console.WriteLine($"EMAIL ADD.\t: {info[userInput][2]}");
                                    Console.WriteLine($"CONTACT NO.\t: {info[userInput][3]}");
                                    Console.ReadKey();

                                }
                                else //if entry is invalid
                                {
                                    Console.WriteLine($"\nEntry [{userInput}] is not found");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }

                            }
                            else if (userInput == "b")
                            {
                                Console.Write("\nPlease input the SURNAME that you want to view:\t");
                                userInput = Console.ReadLine();

                                foreach (KeyValuePair<string, string[]> kvp in info)
                                {
                                    if (info[kvp.Key][0] == userInput)
                                    {
                                        Console.WriteLine($"\nID NUMBER: {kvp.Key}");
                                        Console.WriteLine($"LAST NAME\t: {info[kvp.Key][0]}");
                                        Console.WriteLine($"FIRST NAME\t: {info[kvp.Key][1]}");
                                        Console.WriteLine($"EMAIL ADD.\t: {info[kvp.Key][2]}");
                                        Console.WriteLine($"CONTACT NO.\t: {info[kvp.Key][3]}");
                                        Console.WriteLine();
                                    }

                                }

                                Console.ReadKey();
                            }
                        }
                        else //if there are no entries
                        {
                            Console.WriteLine("\nThere are no entries to view.\nPress any key to continue...");
                            Console.ReadKey();
                        }

                        Console.Clear();
                        break;

                    case "d": // view all

                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine("     VIEW ALL");
                        Console.WriteLine("+--+--+--+--+--+--+");

                        if (info.Count != 0)
                        {
                            foreach (KeyValuePair<string, string[]> kvp in info)
                            {
                                Console.WriteLine($"\nID: {kvp.Key}");
                                Console.WriteLine($"LAST NAME\t: {info[kvp.Key][0]}");
                                Console.WriteLine($"FIRST NAME\t: {info[kvp.Key][1]}");
                                Console.WriteLine($"EMAIL ADD.\t: {info[kvp.Key][2]}");
                                Console.WriteLine($"CONTACT NO.\t: {info[kvp.Key][3]}");
                                Console.WriteLine();
                            }

                            Console.ReadKey();
                        }
                        else //if there are no entries
                        {
                            Console.WriteLine("\nThere are no entries to view.\nPress any key to continue...");
                            Console.ReadKey();
                        }

                        Console.Clear();
                        break;

                    case "e": //remove an entry

                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine("  REMOVE AN ENTRY");
                        Console.WriteLine("+--+--+--+--+--+--+");

                        if (info.Count != 0)
                        {
                            Console.WriteLine("\nChoose which method to search:\n[A] ID\n[B] SURNAME");
                            Console.Write("\nANSWER:\t");
                            userInput = Console.ReadLine().ToLower();

                            if (userInput == "a")
                            {
                                Console.Write("\nPlease input the ID that you want to delete:\t");
                                userInput = Console.ReadLine();

                                if (info.ContainsKey(userInput))
                                {
                                    Console.WriteLine($"LAST NAME\t: {info[userInput][0]}");
                                    Console.WriteLine($"FIRST NAME\t: {info[userInput][1]}");
                                    Console.WriteLine($"EMAIL ADD.\t: {info[userInput][2]}");
                                    Console.WriteLine($"CONTACT NO.\t: {info[userInput][3]}");
                                    Console.WriteLine($"\nEntry {userInput} is currently being deleted...");
                                    Console.ReadKey();

                                    id = userInput;
                                    info.Remove(userInput);
                                    Console.WriteLine($"Entry {id} has been deleted!\n");
                                    Console.ReadKey();
                                }
                                else //if entry is invalid
                                {
                                    Console.WriteLine($"\nEntry [{userInput}] is not found");
                                    Console.WriteLine("\nPress any key to continue...");
                                    Console.ReadKey();
                                }

                            }
                            else if (userInput == "b")
                            {
                                Console.Write("\nPlease input the SURNAME that you want to delete:\t");
                                userInput = Console.ReadLine();

                                foreach (KeyValuePair<string, string[]> kvp in info)
                                {
                                    if (info[kvp.Key][0] == userInput)
                                    {
                                        Console.WriteLine($"\nID: {kvp.Key}");
                                        Console.WriteLine($"LAST NAME\t: {info[kvp.Key][0]}");
                                        Console.WriteLine($"FIRST NAME\t: {info[kvp.Key][1]}");
                                        Console.WriteLine($"EMAIL ADD.\t: {info[kvp.Key][2]}");
                                        Console.WriteLine($"CONTACT NO.\t: {info[kvp.Key][3]}");
                                        Console.WriteLine();

                                        Console.WriteLine("\nDo you want to remove this entry? [A] Yes\t[B] No");
                                        Console.Write("\nANSWER:\t");
                                        string temp = Console.ReadLine().ToLower();

                                        if (temp == "a")
                                        {
                                            id = kvp.Key;
                                            Console.WriteLine($"\nEntry [{id}] is currently being deleted...");
                                            info.Remove(kvp.Key);
                                            Console.WriteLine($"Entry [{id}] has been deleted!\n");
                                            Console.ReadKey();
                                            break;
                                        }

                                        Console.WriteLine("\n--------------------------------------");
                                    }

                                }
                            }
                        }
                        else //if there are no entries
                        {
                            Console.WriteLine("\nThere are no entries to remove.\nPress any key to continue...");
                            Console.ReadKey();
                        }

                        Console.Clear();
                        break;

                    case "f": //exit the program
                        Console.WriteLine("\n+--+--+--+--+--+--+");
                        Console.WriteLine(" PROGRAM HAS ENDED.");
                        Console.WriteLine("+--+--+--+--+--+--+\n");
                        run = false;
                        break;
                }

            }
        }
    }
}
