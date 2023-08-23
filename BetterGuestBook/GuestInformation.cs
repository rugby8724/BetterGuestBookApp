using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGuestBook
{
    internal class GuestInformation
    {
        public static void GetGuestInformation(List<GuestModel> guests)
        {
            
            string MoreGuestComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                
                guest.FirstName = GetInformationFromConsole("What is your first name? ");

                guest.LastName = GetInformationFromConsole("What is your last name? ");

                guest.MessageToHost = GetInformationFromConsole("What message would you like to tell  your host? ");

                MoreGuestComing = GetInformationFromConsole("Are more guest coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (MoreGuestComing.ToLower() == "yes");
        }

        public static string GetInformationFromConsole(string message)
        {
            string output = "";

            Console.WriteLine(message);
            output = Console.ReadLine();

            return output;
        }

        public static void PrintGuestInformation(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        
    }
}
