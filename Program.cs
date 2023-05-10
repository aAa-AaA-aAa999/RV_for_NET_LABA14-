using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo btn;    //Переменная для чтения нажатия клавиши 
        do
        {
            Console.Write("Введите IP-адрес: ");
            string ip = Console.ReadLine();

            string patternIPv4 = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.)
                             {3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

            string patternIPv6 = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$|" +
                    "^([0-9a-fA-F]{1,4}:){1,7}:$|" +
                    "^([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}$|" +
                    "^([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}$|" +
                    "^([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}$|" +
                    "^([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}$|" +
                    "^([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}$|" +
                    "^[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})$|" +
                    "^(:(((:([0-9a-fA-F]){1,4}){1,7})|:))$";

            Match matchIPv4 = Regex.Match(ip, patternIPv4);
            Match matchIPv6 = Regex.Match(ip, patternIPv6);

            if (matchIPv4.Success)
            {
                Console.WriteLine("Это IPv4-адрес.");
            }
            else if (matchIPv6.Success)
            {
                Console.WriteLine("Это IPv6-адрес.");
            }
            else
            {
                Console.WriteLine("Это не является IP-адресом.");
            }

            btn = Console.ReadKey();  // Чтение нажатия клавиши   
        }
        while (!(btn.Key == ConsoleKey.F));
    }
}