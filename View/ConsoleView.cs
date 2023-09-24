using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Gladiator.View
{
    public class ConsoleView : IView
    {
        private readonly int startNumber = 1;
        private readonly int endNumber = 10;
        public void Display(string message, bool newline = false)
        {
            Console.Write(newline ? message + Environment.NewLine : message);
        }

        public int GetNumberBetween()
        {
            int userNumber;

            do
            {
                Display((string.Format(Messages.InputPrompt, startNumber, endNumber)));
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userNumber))
                {
                    if (userNumber >= startNumber && userNumber <= endNumber)
                    {
                        return userNumber;
                    }
                    else
                    {
                        Display(Messages.EntryOutOfRange);
                    }
                }
                else
                {
                    Display(Messages.InvalidEntry);
                }

            } while (true);
        }
    }
}