using ClassCode.Entities.Enums;

namespace ClassCode.Entities
{
    public static class TextHelper
    {
        public static int MessagesGenerated { get; set; } = 0;

        public static void GenerateStatusMessages(OrderStatus status)
        {
            string result = "";
            switch (status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Proccesing] The order is being proccessed";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Delivered] The order is successfully delivered";
                    break;
                case OrderStatus.DeliveryInProgreess:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[Delivery in progress] The order is in progress";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Could not be Delivered] The order could not be delivered";
                    break;
                default:
                    break;

            }
            Console.WriteLine(result);
            Console.ResetColor();
            MessagesGenerated++;
        }

        public static string CapitalFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return "Empty word";
            }else if (word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }
        public static int ValidateNumberInput(string input)
        {
            int choice = 0;
            bool isMenuChoiceValid = int.TryParse(input, out choice);
            if (!isMenuChoiceValid)
            {
                Console.WriteLine("Wrong input. . .");
                return -1;
            }
            return choice;
        }
    }
}
