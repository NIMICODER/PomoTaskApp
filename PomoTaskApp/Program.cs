namespace PomoTaskApp
{
    internal class Program
    {

        public static double ConvertMinutesToMilliseconds(int minutes)
        {
            return TimeSpan.FromMinutes(minutes).TotalMilliseconds;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Pomo task DashBoard");


            while (true)
            {
               

                
                Console.WriteLine("Enter work time in minutes: ");
                int workTime = Convert.ToInt32(Console.ReadLine());

                


                Console.WriteLine("\nEnter rest time in minutes: ");
                int restTime = Convert.ToInt32(Console.ReadLine());
                


                
                int convertWorkTimeToMs = (int)ConvertMinutesToMilliseconds(workTime);
                int convertRestTimeToMs = (int)ConvertMinutesToMilliseconds(restTime);


               
                PomoTimer timer = new PomoTimer(convertWorkTimeToMs, convertRestTimeToMs);



                

                Console.WriteLine("\nDo you want to start?(y/n): ");

                string? startTimer = Console.ReadLine();


                if (startTimer == "y")
                {
                    Console.WriteLine("\nWork timer is running...");
                    timer.beginWork();

                    Console.WriteLine("\nRest timer is running...");
                    timer.restTime();
                }

                else if (startTimer == "n")
                {
                    continue;
                }

                else if (startTimer != "n" && startTimer != "y")
                {
                    Console.WriteLine("\nPlease enter a valid input, y for yes and n for no");
                    continue;
                }


               
                Console.WriteLine("\nWould you like to continue (y/n): ");

                string? continueUsingTimer = Console.ReadLine();

                if (continueUsingTimer == "y")
                {
                    continue;
                }
                else if (continueUsingTimer == "n")
                {
                    break;
                }
                else if (continueUsingTimer != "n" && continueUsingTimer != "y")
                {
                    Console.WriteLine("\nPlease enter a valid input next time, y for yes and n for no");
                    break;
                }

            }

         
           
        }
    }
}