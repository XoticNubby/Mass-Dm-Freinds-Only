using System;
using Discord;
using Leaf.xNet;
using Newtonsoft.Json;

namespace Mass_Dm_For_Freinds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Token: ");
            string token = Console.ReadLine();
            DmFreinds(token);
            Console.WriteLine("Completed");
        }

        static void DmFreinds(string token)
        {

            try
            {
                Console.Write("Message to Send: ");
                string message = Console.ReadLine();
                DiscordClient xotic = new DiscordClient(message);
                var essd = xotic.GetRelationships();

                foreach (ulong VARIABLE in essd)
                {
                    xotic.SendMessage(VARIABLE, message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Message Sent");
                }
            }
            catch (Exception e1)
            {
                
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed");

            }
            

            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}