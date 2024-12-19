using System;

namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare 'another_vacation' outside the loop to persist its value between iterations
            string another_vacation;

            // Start a do-while loop to allow the user to plan multiple vacations
            do
            {
                Boolean validinput = false; // Flag to track valid input for vacation destination
                string choose_place;
                Console.WriteLine("Choose your vacation place: Bodrum, Marmaris, Çeşme");
                choose_place = Console.ReadLine().ToLower(); // Get the user's vacation destination (case insensitive)

                int cost = 0; // Variable to store the base cost of the vacation
                int trip_cost = 0; // Variable to store the cost of the trip (travel cost)

                // While loop to validate the vacation destination
                while (!validinput)
                {
                    switch (choose_place) // Check the user's choice for the destination
                    {
                        case "bodrum":
                            Console.WriteLine($"Cost of the trip is 4000");
                            cost = 4000; // Set cost to 4000 for Bodrum
                            validinput = true; // Mark input as valid
                            break;

                        case "marmaris":
                            Console.WriteLine($"Cost of the trip is 3000");
                            cost = 3000; // Set cost to 3000 for Marmaris
                            validinput = true; // Mark input as valid
                            break;

                        case "çeşme":
                            Console.WriteLine($"Cost of the trip is 5000");
                            cost = 5000; // Set cost to 5000 for Çeşme
                            validinput = true; // Mark input as valid
                            break;

                        default:
                            Console.WriteLine("Error: Please choose from one of the three places."); // Handle invalid input
                            break;
                    }
                }

                // Prompt the user to enter how many people are going
                Console.WriteLine("How many people are going?");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine()); // Get the number of people going on the trip

                // Display additional information about the destination
                if (choose_place == "bodrum")
                {
                    Console.WriteLine("Bodrum is known for its stunning beaches, vibrant nightlife, and historic landmarks. It offers a perfect blend of relaxation and culture.");
                }
                else if (choose_place == "marmaris")
                {
                    Console.WriteLine("Marmaris is a haven for nature lovers and adventure seekers. This picturesque town offers breathtaking views, water sports, and serene coves to explore.");
                }
                else if (choose_place == "çeşme")
                {
                    Console.WriteLine("Çeşme is a charming seaside destination known for its elegant resorts, thermal waters, and pristine beaches. It’s ideal for those seeking both relaxation and luxury.");
                }

                // Ask the user how they would like to travel (road or air)
                Console.WriteLine("How would you like to travel? Type 1 for road travel or 2 for air travel");
                int num = Convert.ToInt32(Console.ReadLine()); // Get the user's travel preference
                Boolean validinput2 = false; // Flag to track valid input for travel method

                // While loop to validate the travel method (1 for road or 2 for air)
                while (!validinput2)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Cost of the trip by road is 1500 per person for round trip.");
                            trip_cost = 1500; // Set travel cost for road trip
                            validinput2 = true; // Mark input as valid
                            break;

                        case 2:
                            Console.WriteLine("Cost of the trip by air is 4000 per person for round trip.");
                            trip_cost = 4000; // Set travel cost for air travel
                            validinput2 = true; // Mark input as valid
                            break;

                        default:
                            Console.WriteLine("Error: Please choose 1 or 2."); // Handle invalid travel choice
                            break;
                    }
                }

                // Calculate the total price based on the number of people and trip cost
                int total_price = (cost * numberOfPeople) + (trip_cost * numberOfPeople);
                Console.WriteLine($"The total price of the vacation is {total_price}.");

                // Ask the user if they want to plan another vacation
                Console.WriteLine("Would you like to plan another vacation? (yes/no)");
                another_vacation = Console.ReadLine().ToLower(); // Get the user's choice to continue or exit the loop

            } while (another_vacation == "yes"); // The loop continues if the user types "yes"

            // End of the program
            Console.WriteLine("Thank you! Have a great day.");
            Console.ReadLine(); // Wait for the user to press enter before closing
        }
    }
}
