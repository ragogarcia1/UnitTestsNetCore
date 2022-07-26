using System;

namespace LibraryRago
{
    public interface ILoggerGeneral
    {
        void Message(string message);
        bool LogDataBase(string message);
        bool LogBalanceLaterWithdrawal(int mount);
    }
    public class LoggerGeneral : ILoggerGeneral
    {
        public bool LogBalanceLaterWithdrawal(int mount)
        {
            if (mount >= 0)
            {
                Console.WriteLine("Success");
                return true;
            }
            Console.WriteLine("Error");
            return false;

        }

        public bool LogDataBase(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LoggerFake : ILoggerGeneral
    {
        public bool LogBalanceLaterWithdrawal(int mount)
        {
            return false;
        }

        public bool LogDataBase(string message)
        {
            return false;
        }

        public void Message(string message)
        {
            
        }
    }
}
