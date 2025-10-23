namespace SwitchWeekDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta täht");

            DayOfWeek today = DayOfWeek.Wednesday;
            string message;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Monday is WorkDay");
                    break;

                    case DayOfWeek.Tuesday:
                    Console.WriteLine("Tuesday is workday");
                    break;

                    case DayOfWeek.Wednesday:
                    Console.WriteLine("Wednesday is workday");
                    break;

                    case DayOfWeek.Thursday:
                    Console.WriteLine("Yhursday is workday");
                    break;

                    case DayOfWeek.Friday:
                    Console.WriteLine("Friday is workday");
                    break;

                    case DayOfWeek.Saturday:
                    Console.WriteLine("Saturday is weekend");
                    break;

                    case DayOfWeek.Sunday:
                    Console.WriteLine("Sunday is weekend");
                    break;

                    default:
                    break;
                    

            }





        }
            
              
            


        
    }
}
