using System;
using System.Collections.Generic;
using System.Threading;

class PrinterQueueProgram
{
    static void Main()
    {
        Queue<string> printerQueue = new Queue<string>();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n=== PRINTER QUEUE MENU ===");
            Console.WriteLine("1. Add Document");
            Console.WriteLine("2. Print Document");
            Console.WriteLine("3. View Queue");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter document name: ");
                    string docName = Console.ReadLine();
                    printerQueue.Enqueue(docName);
                    Console.WriteLine($"'{docName}' added to the print queue.");
                    break;

                case 2:
                    if (printerQueue.Count > 0)
                    {
                        string printingDoc = printerQueue.Dequeue();
                        Console.WriteLine($"Printing: {printingDoc}");
                        Thread.Sleep(1000);
                        Console.WriteLine($"{printingDoc} printed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No documents to print!");
                    }
                    break;

                case 3:
                    if (printerQueue.Count > 0)
                    {
                        Console.WriteLine("Documents in queue:");
                        foreach (var doc in printerQueue)
                        {
                            Console.WriteLine("- " + doc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Print queue is empty!");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}

