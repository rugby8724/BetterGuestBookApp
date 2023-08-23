
using BetterGuestBook;

using GuestBookLibrary;
using GuestBookLibrary.Models;


// Capture the information about each guest (assumption at least one guest and unknown maximum)
// Info to capture: First Name, Last Name, message to host
// Once done, loop through each guest and print their info


List<GuestModel> guests = new List<GuestModel>();

GuestInformation.GetGuestInformation(guests);

GuestInformation.PrintGuestInformation(guests);

Console.ReadLine();